    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Models;

namespace DL1.Repositories
{
    public class KategoriRepository : IRepository<Kategori> //Här skapar vi listan utav kategorier som vi sparar i vår XML-fil
    {
        SerializerForXml dataManager;
        List<Kategori> listOfKategori;

        
        public KategoriRepository()
        {
            dataManager = new SerializerForXml();
            listOfKategori = new List<Kategori>();
            listOfKategori = GetAll();
        }
        public void Create(Kategori entity)
        {
            listOfKategori.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            listOfKategori.RemoveAt(index);
            SaveChanges();
        }

        public List<Kategori> GetAll()
        {
            List<Kategori> listOfKategorierDeserialized = new List<Kategori>();
            try
            {

                listOfKategorierDeserialized = dataManager.DeserializeKategori(); //finns ingen fil första gången den körs
            }
            catch (Exception)
            {

            }
                return listOfKategorierDeserialized;
        }

        public void SaveChanges()
        {
            dataManager.SerializeKategori(listOfKategori);
        }

        public void Update(int index, Kategori entity)
        {
            if(index >= 0)
            {
                listOfKategori[index] = entity;
            }
            SaveChanges();
        }
        public int GetIndex(string namn)
        {
            return GetAll().FindIndex(e => e.Namn.Equals(namn));
        }
    }
}
