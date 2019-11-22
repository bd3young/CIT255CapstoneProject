using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using MonsterDex.DataLayer;

namespace MonsterDex.DataLayer.Repository
{
    class MonstersRepository : IMonstersRepository, IDisposable
    {
        private IDataService _dataService;
        List<Monster> _monsters;

        public MonstersRepository()
        {
            //_dataService = SetDataService();
            _monsters = _dataService.ReadAll() as List<Monster>;
        }

        //private IDataService SetDataService()
        //{
        //    switch (DataConfig.dataType)
        //    {
        //        case DataType.SEED:
        //            return new MonsterSeedData();
        //        default:
        //            break;
        //    }
        //}

        public void Add(Monster monster)
        {
            _monsters.Add(monster);
            _dataService.WriteAll(_monsters);
        }

        public void Delete(int id)
        {
            _monsters.Remove(_monsters.FirstOrDefault(c => c.Id == id));
            _dataService.WriteAll(_monsters);
        }

        public void Dispose()
        {
            _dataService = null;
            _monsters = null;
        }

        public IEnumerable<Monster> GetAll()
        {
            return _monsters;
        }

        public Monster GetById(int id)
        {
            return _monsters.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Monster monster)
        {
            _monsters.Remove(_monsters.FirstOrDefault(c => c.Id == monster.Id));
            _monsters.Add(monster);
            _dataService.WriteAll(_monsters);
        }
    }
}
