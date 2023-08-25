using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using DL1.Repositories;
using Models;


namespace BL.Controllers
{
    public class KategoriController//KategoriController är till för att handskas med utföranden av det visuella
                                    //samtidigt som vi sparar det i XML-filen. Dessa metoder är exempelvis till för 
                                    //att våra knappar i formen ska fungera utefter metoderna under klassen.
    {
        KategoriRepository katRepository;

        public KategoriController()
        {
            katRepository = new KategoriRepository();
        }

        public void CreateKategori(string namn)
        {
            Kategori newKategori = new Kategori(namn);
            katRepository.Create(newKategori);
        }

        public List<Kategori> GetAllKategori()
        {
            return katRepository.GetAll();
        }
        public void DeleteKategori(string namn)
        {
            int index = katRepository.GetIndex(namn);
            katRepository.Delete(index);
        }

    }

}