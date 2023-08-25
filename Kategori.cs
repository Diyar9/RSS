using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS
{
    public class Kategori : Lank
    {
        public Kategori(string namn, int antal, int frekvens, string kategori, string avsnittnamn) : base(namn, antal, frekvens, kategori, avsnittnamn)
        {
            
        }
        private Kategori()
        {

        }
        public override string Display()
        {
            return "This file is called " + Namn + " and belongs in " + Kategori + ".";
        }
    }
}
