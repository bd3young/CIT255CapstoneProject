using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using MonsterDex.DataLayer;
using MonsterDex.BusinessLayer;

namespace MonsterDex.DataLayer.Repository
{
    class MonstersRepository : IMonstersRepository, IDisposable
    {
        private IDataService _dataService;
        List<Monster> _monsters;

        public MonstersRepository()
        {
            _dataService = SetDataService();
            try
            {
                _monsters = _dataService.ReadAll() as List<Monster>;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private IDataService SetDataService()
        {
            switch (DataConfig.dataType)
            {
                case DataType.XML:
                    return new DataServiceXml();
                default:
                    throw new Exception();
            }
        }

        public void Add(Monster monster)
        {

            monster.Id = NextId();
            monster.Id++;
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

        private int NextId()
        {
            //
            // get maximum id number and return incremented value
            //
            return _monsters.OrderByDescending(c => c.Id).First().Id;
        }
    }
}
