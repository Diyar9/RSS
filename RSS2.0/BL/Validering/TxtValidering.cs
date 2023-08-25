using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validering
{
    public class TxtValidering
    {
        public void txtValidering(string input)
        {
            if(input == null || input.Length <= 0)
            {
                throw new ExceptionValidering("Fyll i alla textfält");
            }
        }

        public void katNamnValidering(string input)
        {
            if (input == null || input.Length <= 0)
            {
                throw new ExceptionValidering("Fyll i textfältet för kategori");
            }
        }
    }
}
