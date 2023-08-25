using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Podcast:Lank
    {
        public Podcast() 
        {

        }

        public Podcast(string url, string namn, Kategori kategori, double frekvens) : base(url, namn, kategori, frekvens)
        {
            Url = url;
            Namn = namn;
            Kategori = kategori;
            Frekvens = frekvens;
            AntalAvsnitt = 0;
        }

        public override string Display()
        {
            return base.Display();
        }
    }
}

