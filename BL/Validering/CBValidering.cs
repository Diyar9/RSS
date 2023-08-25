using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validering
{
    public class CBValidering
    {
        public void ValideraCB(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ExceptionValidering("ComboBoxen måste vara ifylld");
            }
        }
    }
}
