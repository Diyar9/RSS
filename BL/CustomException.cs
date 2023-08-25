using BL.Validering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class CustomException
    {
        public static void CustomExceptions(Exception ce)
        {
            if (ce.GetType() == typeof(ExceptionValidering))
            {
                MessageBox.Show(ce.Message, "Validering misslyckad", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ce.Message, "Något gick snett", MessageBoxButtons.OK);
            }
        }
    }
}
