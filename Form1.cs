using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Models;
using BL;
using BL.Controllers;
using BL.Validering;
using DL;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using DL1.Repositories;
using System.Threading;

namespace RSS

{
    public partial class Form1 : Form
    {

        KategoriController kategoriController;
        LankController lankController;
        List<Podcast> pLista = new List<Podcast>();
        Podcast valdPodcast = null;
        URLValidering urlValidering = new URLValidering();
        TxtValidering textValidering = new TxtValidering();
        CBValidering cbValidering = new CBValidering();


        public Form1()
        {
            InitializeComponent();
            lankController = new LankController();
            kategoriController = new KategoriController();
            UppdateraKategoriListan();
            UppdateraPodcastListan();
            uppdateringfrekbox.Items.Add("10 sekunder");
            uppdateringfrekbox.Items.Add("30 sekunder");
            uppdateringfrekbox.Items.Add("60 sekunder");
        }

        private void UppdateraPodcastListan() //Uppdatera ListView (tabbelListView)
        {
            try
            {
                var getLanks = lankController.GetAlllanks(); 
                foreach (var (item, dm) in from item in getLanks //itererar genom getLanks där item är iterator
                                           let dm = new ListViewItem() //och innehåller podcast. Dm är en ny ListView 
                                           select (item, dm)) //select sätter varje uppdaterad podcast item återigen i listView
                {
                    //här sätts värden för varje egenskap i varje podcasts under kolumnerna i listView
                    dm.Text = item.Namn;
                    dm.SubItems.Add(item.AntalAvsnitt.ToString());
                    dm.SubItems.Add((item.Frekvens / 1000).ToString() + " Sek");
                    dm.SubItems.Add(item.Kategori.Namn);
                    tabbelListView.Items.Add(dm);
                }
            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void UppdateraKategoriListan()
        {
            
            var getKat = kategoriController.GetAllKategori();
            foreach(var item in getKat)//här itererar vi genom alla kategorier och lägger till dom i båda kategori boxarna
            {
                kategorierlistbox.Items.Add(item.Namn);
                kategoribox.Items.Add(item.Namn); 
            }
        }
        


        private void prenumererabtn_Click(object sender, EventArgs e)
        {
            try
            {

                urlValidering.valideraUrl(urltxt.Text); //validators
                textValidering.txtValidering(urlNamntxt.Text);
                cbValidering.ValideraCB((string)uppdateringfrekbox.SelectedItem);
                cbValidering.ValideraCB((string)kategoribox.SelectedItem);
                tabbelListView.Items.Clear(); //rensa listView för att återskapa den nya versionen

                var url = urltxt.Text;
                var frekvens = uppdateringfrekbox.SelectedItem.ToString().Substring(0, 2);
                double matfrekvens = Convert.ToDouble(frekvens) * 1000;
                var kategori = kategoribox.SelectedItem.ToString();
                var namn = urlNamntxt.Text;
                foreach (var newKategori in from item in kategoriController.GetAllKategori()
                                            where item.Namn == kategori
                                            let newKategori = new Kategori()
                                            select newKategori)
                {
                    newKategori.Namn = kategori;
                    lankController.CreateLank(url, namn, newKategori, matfrekvens, "Podcast");
                }

                var getLanks = lankController.GetAlllanks();
                foreach (var (item, dm) in from item in getLanks
                                           let dm = new ListViewItem()
                                           select (item, dm))
                {
                    dm.Text = item.Namn;
                    dm.SubItems.Add(item.AntalAvsnitt.ToString());
                    dm.SubItems.Add((item.Frekvens / 1000).ToString() + " Sek");
                    dm.SubItems.Add(item.Kategori.Namn);
                    tabbelListView.Items.Add(dm);
                }
                urltxt.Clear();
                urlNamntxt.Clear();
                
                
            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void urlNamntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void urlnamnlbl_Click(object sender, EventArgs e)
        {

        }

        private void urltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void urllbl_Click(object sender, EventArgs e)
        {

        }

        private void uppdateringfrekbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabortbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kategorierlistbox.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Du kommer nu att ta bort kategorin samt tillhörande podcasts.", "Ta bort",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var vald = kategorierlistbox.SelectedItem.ToString();
                        RaderaKategori(vald);
                        kategoriController.DeleteKategori(vald);
                        kategorierlistbox.Items.Clear();
                        kategoribox.Items.Clear();
                        UppdateraKategoriListan();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Vänligen klicka på den kategorin du vill ta bort!");
                }
            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void RaderaKategori(string kategori)
        {
            tabbelListView.Items.Clear();
            var raderaPodcast = lankController.GetAlllanks();
            if (kategori != null)
            {
                raderaPodcast = raderaPodcast.Where(x => x.Kategori.Namn == kategori).ToList();
            }

            foreach(var item in raderaPodcast)
            {
                lankController.DeleteLank(item.Namn);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void laggtillbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                textValidering.katNamnValidering(namnKategoritxt.Text);
                kategorierlistbox.Items.Clear();
                kategoribox.Items.Clear();

                var kategoriNamn = namnKategoritxt.Text;
                kategoriController.CreateKategori(kategoriNamn);
                foreach (var item in from Kategori item in kategoriController.GetAllKategori()
                                     where kategoriController.GetAllKategori().Contains(item) == false
                                     select item)
                    {
                        kategoribox.Items.Add(item.Namn);
                        kategorierlistbox.Items.Add(item.Namn);
                    }
                    namnKategoritxt.Clear();
             }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
            }
            
    


        private void tabbelListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            valdPodcast = null;
            avsnittlistbox.Items.Clear();
            beskrivningtxt.Clear();
            if (tabbelListView.SelectedItems.Count == 1)
            {
                try
                {
                    pLista = lankController.GetAlllanks();
                    var clickedPodcast = tabbelListView.SelectedItems[0].Text;
                    var podcast = pLista.Find(x => x.Namn == clickedPodcast);
                    valdPodcast = podcast;
                    urlNamntxt.Text = valdPodcast.Namn;
                    urltxt.Text = valdPodcast.Url;
                    uppdateringfrekbox.Text = (valdPodcast.Frekvens / 1000).ToString() + " sek";
                    kategoribox.Text = valdPodcast.Kategori.Namn;
                    foreach(Avsnitt avsnitt in valdPodcast.avsnittsLista)
                    {
                        avsnittlistbox.Items.Add(avsnitt.Titel);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void kategoribox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kategorierlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(kategorierlistbox.SelectedItems.Count == 1)
            {
                avsnittlistbox.Items.Clear();
                beskrivningtxt.Clear();
                var vald = kategorierlistbox.SelectedItem.ToString();
                FiltreraKategori(vald);
            }
        }

        private void FiltreraKategori(string kategori)
        {
            tabbelListView.Items.Clear();
            var visarNuvarandePodcast = lankController.GetAlllanks();
            if (kategori != null)
            {
                visarNuvarandePodcast = visarNuvarandePodcast.Where(x => x.Kategori.Namn == kategori).ToList();
            }
            foreach (var (item, dm) in from item in visarNuvarandePodcast
                                       let dm = new ListViewItem()
                                       select (item, dm))
            {
                dm.Text = item.Namn;
                dm.SubItems.Add(item.AntalAvsnitt.ToString());
                dm.SubItems.Add((item.Frekvens / 1000).ToString() + " sek");
                dm.SubItems.Add(item.Kategori.Namn);
                tabbelListView.Items.Add(dm);
            }
        }

        private void sparabtn_Click(object sender, EventArgs e)
        {
            try
            {
                var valdPod = tabbelListView.SelectedItems[0].Text;
                var url = urltxt.Text;
                var namn = urlNamntxt.Text;
                var kategori = kategoribox.SelectedItem.ToString();
                var frekvens = uppdateringfrekbox.Text.ToString().Substring(0,2);
                var matfrekvens = Convert.ToDouble(frekvens)*1000;
                Kategori newKategori = new Kategori();
                newKategori.Namn = kategori;

                lankController.DeleteLank(valdPod);
                lankController.CreateLank(url, namn, newKategori, matfrekvens, "Podcast");
                tabbelListView.Items.Clear();
                UppdateraPodcastListan();

            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void sparabtn2_Click(object sender, EventArgs e)
        {
            try
            {
                textValidering.katNamnValidering(namnKategoritxt.Text);

                if (kategorierlistbox.SelectedIndex >= 0)
                {
                    var gammalKategori = kategorierlistbox.SelectedItem.ToString();
                    var nyKategori = namnKategoritxt.Text;
                    NyVersionKategori(gammalKategori, nyKategori);
                    kategoriController.DeleteKategori(gammalKategori);
                    kategoriController.CreateKategori(nyKategori);
                    kategorierlistbox.Items.Clear();
                    tabbelListView.Items.Clear();
                    kategoribox.Items.Clear();
                    beskrivningtxt.Clear();
                    UppdateraKategoriListan();
                    UppdateraPodcastListan();
                }
                else
                {
                    MessageBox.Show("Vänligen klicka på den kategori du vill uppdatera.");
                }
            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void NyVersionKategori(string gammalKategori, string nyKategori)
        {
            tabbelListView.Items.Clear();
            List<Podcast> uppdaterarPodcasten = new List<Podcast>();
            Kategori kategori = new Kategori(nyKategori);
            var raderarPodcasten = lankController.GetAlllanks();
            if (nyKategori != null)
            {             
                    raderarPodcasten = raderarPodcasten.Where(x => x.Kategori.Namn == gammalKategori).ToList();
            }
            foreach(var item in raderarPodcasten)
            {
                lankController.CreateLank(item.Url, item.Namn, kategori, item.Frekvens, "Podcast");
                uppdaterarPodcasten.Add(item);
                lankController.DeleteLank(item.Namn);
            }
            foreach (var item in uppdaterarPodcasten)
            {
                ListViewItem dm = new ListViewItem();

                dm.Text = item.Namn;
                dm.SubItems.Add((item.AntalAvsnitt / 2).ToString());
                dm.SubItems.Add(item.Frekvens.ToString());
                dm.SubItems.Add(item.Kategori.Namn);
                tabbelListView.Items.Add(dm);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            tabbelListView.Items.Clear();
            kategorierlistbox.Items.Clear();
            avsnittlistbox.Items.Clear();
            beskrivningtxt.Clear();
            urlNamntxt.Clear();
            namnKategoritxt.Clear();
            urltxt.Clear();
            kategoribox.Items.Clear();
            kategoribox.Text = "";
            uppdateringfrekbox.Text = "";  
            UppdateraKategoriListan();
            UppdateraPodcastListan();
        }

        private void tabortbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    urlValidering.valideraUrl(urltxt.Text);
                    textValidering.txtValidering(urlNamntxt.Text);
                    cbValidering.ValideraCB((string)uppdateringfrekbox.SelectedItem);
                    cbValidering.ValideraCB((string)kategoribox.SelectedItem);

                    var vald = tabbelListView.SelectedItems[0].Text;
                    lankController.DeleteLank(vald);
                    tabbelListView.Items.Clear();
                    urltxt.Clear();
                    urlNamntxt.Clear();
                    avsnittlistbox.Items.Clear();
                    beskrivningtxt.Clear();
                    UppdateraPodcastListan();
                }
                else
                {
                    MessageBox.Show("Vänligen välj en podcast.");
                }
            }
            catch (Exception ce)
            {
                CustomException.CustomExceptions(ce);
            }
        }

        private void avsnittlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (avsnittlistbox.SelectedIndex >= 0)
            {
                beskrivningtxt.Clear();

                var valdAvsnittTitel = avsnittlistbox.SelectedItem.ToString();
                var valdAvsnitt = valdPodcast.avsnittsLista.Find(x => x.Titel == valdAvsnittTitel);
                beskrivningtxt.Text = valdAvsnitt.Beskrivning;
            }
        }


        static void AsyncMetod()
        {
            Thread.Sleep(2000);
            MessageBox.Show("Async metod är under process...");
        }

        static async Task KopplaAsyncMetod()
        {
            Action aVoid = AsyncMetod;

            await Task.Run(aVoid);
        }

        private async void btnVisaInfo_Click(object sender, EventArgs e)
        {
            Task asyncVoidOperation = KopplaAsyncMetod();
            await asyncVoidOperation;

            if (tabbelListView.SelectedItems.Count < 1 == false)
            {
                pLista = lankController.GetAlllanks();
                var nuvarandePodcast = tabbelListView.SelectedItems[0].Text;
                var pod = pLista.Find(x => x.Namn == nuvarandePodcast);
                valdPodcast = pod;
                MessageBox.Show(pod.Display());
            }
            else
            {
                MessageBox.Show("Välj en pod och klicka sedan på denna knapp!");
            }
        }
    }
}
