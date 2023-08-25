using DL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DL1.Repositories
{
    public class LankRepository : ILankRepository<Podcast>//Här skapar vi vår lista av podcasts och sparar i XML-fil
    {
        SerializerForXml dataManager;
        List<Podcast> listOfLinks;

        public LankRepository()
        {
            dataManager = new SerializerForXml();
            listOfLinks = new List<Podcast>();
            listOfLinks = GetAll();
        }

        public void Create(Podcast podcast)
        {
            podcast = dataManager.SerializeUrl(podcast, podcast.Url);
            listOfLinks.Add(podcast);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfLinks.RemoveAt(index);
            SaveChanges();
        }

        public void SaveChanges()
        {
            dataManager.Serialize(listOfLinks);
        }

        public void Update(int index, Podcast podcast)
        {
            if(index >= 0)
            {
                listOfLinks[index] = dataManager.SerializeUrl(podcast, podcast.Url);
            }
            SaveChanges();
        }

        public List<Podcast> GetAll()
        {
            List<Podcast> listOfFeedDeserialized = new List<Podcast>();
            try
            {
                listOfFeedDeserialized = dataManager.Deserialize();
            }
            catch (Exception)
            {
                throw;
            }
            return listOfFeedDeserialized;
        }

        public Podcast GetBy(string titel)
        {
            return GetAll().FirstOrDefault(e => e.Namn.Equals(titel));
        }
        public Podcast GetBy(Kategori kategori)
        {
            return GetAll().FirstOrDefault(e => e.Kategori.Equals(kategori));
        }
        public int GetIndex(string titel)
        {
            return GetAll().FindIndex(e => e.Namn.Equals(titel));
        }


    }
}
