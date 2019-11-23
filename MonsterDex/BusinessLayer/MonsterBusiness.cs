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
                GetMonsterName();
                InstantiateAndShowView();
            }
        }

        private void GetMonsterName()
        {
            foreach (Monster MonsterName in _allMonsters)
            {
                _monsterName.Add(MonsterName.Name);
            }
        }

        private void InstantiateAndShowView()
        {
            _monsterDexViewModel = new MonsterDexViewModel(_allMonsters, _monsterName);
            MonsterDexView monsterDexView = new MonsterDexView(_monsterDexViewModel);

            monsterDexView.DataContext = _monsterDexViewModel;

            monsterDexView.Show();
        }
    }
}
