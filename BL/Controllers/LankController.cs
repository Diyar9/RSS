using DL1.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Controllers
{
    public class LankController //LankController är till för att handskas med utföranden av det visuella
                                //samtidigt som vi sparar det i XML-filen. Dessa metoder är exempelvis till för 
                                //att våra knappar i formen ska fungera utefter metoderna under klassen.
    {
        ILankRepository<Podcast> lankRepository;

        public LankController()
        {
            lankRepository = new LankRepository();
        }
        public void CreateLank(string url, string namn, Kategori kategori, double frekvens, string objectType)
        {
            Podcast newPodcast = new Podcast(url, namn, kategori, frekvens);
            lankRepository.Create(newPodcast);
            Update(newPodcast);
        }

        public List<Podcast> GetAlllanks()
        {
            return lankRepository.GetAll();
        }

        public void Update(Podcast podcast)
        {
            int index = GetIndexController(podcast.Namn);
            podcast.NextUpdate = DateTime.Now.AddMilliseconds(podcast.Frekvens);

            lankRepository.Update(index, podcast);
        }

        public void DeleteLank(string titel)
        {
            int index = lankRepository.GetIndex(titel);
            lankRepository.Delete(index);
        }
        public int GetIndexController(string titel)
        {
            return lankRepository.GetIndex(titel);
        }
        public void UpdateFeed(int index, Podcast flode)
        {
            lankRepository.Update(index, flode);
        }

        public string GetMessage(Podcast podcast)
        {
            return podcast.Display();
        }


    }
}
