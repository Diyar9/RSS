using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public string Titel;
        public string Beskrivning;

        public class AvsnittLista : List<Avsnitt>
        {
            public AvsnittLista()
            {

            }
        }
    }
}