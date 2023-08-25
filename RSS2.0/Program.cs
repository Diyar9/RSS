using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DL;
using Models;
using RSS;

namespace RSS
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            //Lank lank1 = new Podcast("url://", "Lincoln", null,30);
            //SerializerForXml serializerForXml = new SerializerForXml();
            //serializerForXml.Serialize1(lank1);

            Application.Run(new Form1());
        }
    }
}
