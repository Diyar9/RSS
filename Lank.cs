using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;  

namespace RSS
{
    [XmlInclude(typeof(Kategori))]
    public abstract class Lank
    {
        public string Namn { get; set; }
        public int Antalavsnitt { get; set; }
        public int Frekvens { get; set; }
        public string Kategori { get; set; }
        public string AvsnittNamn { get; set; }
        public Lank(string namn, int antal, int frekvens, string kategori, string avsnittnamn)
        {
            Namn = namn;
            Antalavsnitt = antal;
            Frekvens = frekvens;
            Kategori = kategori;
            AvsnittNamn = avsnittnamn;
        }
        public Lank()
        {

        }
        public abstract string Display();
    }
}
