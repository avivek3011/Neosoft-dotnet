using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface ICatRepository
    {
        IEnumerable<Cat> GetCats();
        Cat GetCatById(int? id);
        void AddCat(Cat cat);
        Cat UpdateCat(Cat cats);
        void DeleteCat(int id);
        void Save();
    }
}
