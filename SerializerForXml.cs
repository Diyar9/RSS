using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RSS;
using static System.Windows.Forms.LinkLabel;

namespace RSS
{
    internal class SerializerForXml
    {
        public void Serialize(List<Lank> lank)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Lank>));

            using (FileStream fileStream = new FileStream("Lankar.xml",
                FileMode.Append, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, lank);
            }
        }

        public List<Lank> Deserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Lank>));

            using (FileStream fileStream = new FileStream("Lankar.xml",
                FileMode.Open, FileAccess.Read))
            {
                return (List<Lank>)xmlSerializer.Deserialize(fileStream);
            }
        }
    }
}
