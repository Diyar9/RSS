    using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL1.Repositories
{
    public interface ILankRepository<T> : IRepository<T> where T : Podcast //Utöver IRepository, andra funktioner för länkar
    {
        T GetBy (string titel);
        T GetBy(Kategori kategori);
        int GetIndex(string titel);

    }
}
