using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Models;
using DL.Exceptions;
using System.Linq.Expressions;
using System.Xml;
using System.ServiceModel.Syndication;

namespace DL
{
    public class SerializerForXml
    {
        public void Serialize(List<Podcast> podList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream impFile = new FileStream("Podcast.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(impFile, podList);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SerializeKategori(List<Kategori> kategoriList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream impFile = new FileStream("Kategori.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(impFile, kategoriList);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Podcast> Deserialize()
        {
            try
            {
                if (File.Exists("Podcast.xml") == false)
                {
                    return new List<Podcast>();
                }
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream visaFile = new FileStream("Podcast.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(visaFile);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public List<Kategori> DeserializeKategori()
        {
            try
            {
                if (File.Exists("Kategori.xml") == false)
                {
                    return new List<Kategori>();
                }
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream visaFile = new FileStream("Kategori.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Kategori>)xmlSerializer.Deserialize(visaFile);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Podcast SerializeUrl(Podcast podcast, string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);


            foreach (SyndicationItem item in feed.Items)
            {
                Avsnitt avsnitt = new Avsnitt();
                avsnitt.Titel = item.Title.Text;
                avsnitt.Beskrivning = item.Summary.Text;
                podcast.avsnittsLista.Add(avsnitt);
                podcast.AntalAvsnitt++;
            }
            return podcast;
        }
    }
}
