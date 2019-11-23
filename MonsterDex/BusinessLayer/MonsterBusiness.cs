using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using MonsterDex.DataLayer;
using MonsterDex.PresentationLayer;

namespace MonsterDex.BusinessLayer
{
    public class MonsterBusiness
    {
        bool _xmlBool = false;

        MonsterDexViewModel _monsterDexViewModel;
        List<Monster> _allMonsters = new List<Monster>();
        List<string> _monsterName = new List<string>();
        List<int> _monsterId = new List<int>();

        public MonsterBusiness()
        {

            SetupMonsters();

        }


        private void SetupMonsters()
        {
            if (_xmlBool)
            {

            }
            else
            {
                _allMonsters = MonsterSeedData.GenerateListOfMonsters();
                GetMonsterNameId();
                InstantiateAndShowView();
            }
        }

        private void GetMonsterNameId()
        {
            foreach (Monster MonsterName in _allMonsters)
            {
                _monsterId.Add(MonsterName.Id);
                _monsterName.Add(MonsterName.Name);
            }
        }

        private void InstantiateAndShowView()
        {
            _monsterDexViewModel = new MonsterDexViewModel(_allMonsters, _monsterId, _monsterName);
            MonsterDexView monsterDexView = new MonsterDexView(_monsterDexViewModel);

            monsterDexView.DataContext = _monsterDexViewModel;

            monsterDexView.Show();
        }
    }
}
