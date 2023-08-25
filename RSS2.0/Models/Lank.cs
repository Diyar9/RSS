using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Models
{
    [XmlInclude(typeof(Podcast))]
    public abstract class Lank
    {
        public string Url { get; set; }
        public string Namn { get; set; }
        public Kategori Kategori { get; set; }
        public double Frekvens { get; set; }
        public int AntalAvsnitt { get; set; }
        public DateTime NextUpdate { get; set; }

        public List<Avsnitt> avsnittsLista = new List<Avsnitt>();

        public Lank(string url, string namn, Kategori kategori, double frekvens)
        {
            Url = url;
            Namn = namn;
            Kategori = kategori;
            Frekvens = frekvens;
            AntalAvsnitt = 0;
        }
        public Lank()
        {

        }
        public virtual string Display()
        {
            return "Denna podcast heter: " + Namn + ", tillhör kategorin: "
                + Kategori.Namn + ", och innehåller " + AntalAvsnitt + " avsnitt!";
        }
    }
}