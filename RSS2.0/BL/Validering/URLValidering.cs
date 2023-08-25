using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validering
{
    public class URLValidering
    {
        public void valideraUrl(string input)
        {
            if (Uri.IsWellFormedUriString(input, UriKind.Absolute) == false) //En fördefinierad metod för att kolla att URL är i rätt format
            {
                throw new ExceptionValidering("Mata in ett giltigt URL");
            }
        }
    }
}
