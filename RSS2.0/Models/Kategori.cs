using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [XmlInclude(typeof(Kategori))]
    public class Kategori
    {
        public string Namn;

        public Kategori(string namn)
        {
            Namn = namn;
        }

        public Kategori()
        {

        }
    }
}
