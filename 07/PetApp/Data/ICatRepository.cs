using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    interface ICatRepository
    {
        IEnumerable<Cat> GetCats();
        Cat GetCatById(int id);
        void AddCat(Cat cat);
        void UpdateCat(int id);
        void DeleteCat(int id);
        void Save();
    }
}
