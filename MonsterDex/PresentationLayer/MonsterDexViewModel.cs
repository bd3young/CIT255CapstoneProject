using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.PresentationLayer
{
    public class MonsterDexViewModel
    {
        private List<Monster> _allMonsters;
        private List<string> _monsterName;

        public List<Monster> AllMonsters
        {
            get { return _allMonsters; }
            set { _allMonsters = value; }
        }

        public List<string> MonsterName
        {
            get { return _monsterName; }
            set { _monsterName = value; }
        } 

        public MonsterDexViewModel()
        {

        }

        public MonsterDexViewModel(List<Monster> allMonsters, List<string> monsterName)
        {   
            _allMonsters = allMonsters;
            _monsterName = monsterName;

        }
    }
}
