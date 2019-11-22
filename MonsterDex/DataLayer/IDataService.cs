using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.DataLayer
{
    public interface IDataService
    {

        IEnumerable<Monster> ReadAll();
        void WriteAll(IEnumerable<Monster> monsters);

    }
}
