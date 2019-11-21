using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.DataLayer.Repository
{
    interface IMonstersRepository
    {
        IEnumerable<Monster> GetAll();
        Monster GetById(int id);
        void Add(Monster monster);
        void Update(Monster monster);
        void Delete(int id);
    }
}
