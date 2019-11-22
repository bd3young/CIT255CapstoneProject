using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.PresentationLayer
{
    class MonsterDexViewModel
    {
        private List<Monster> _allMonsters;

        public List<Monster> AllMonsters
        {
            get { return _allMonsters; }
            set { _allMonsters = value; }
        }


        public MonsterDexViewModel()
        {

        }

        public MonsterDexViewModel(List<Monster> allMonsters)
        {   
            _allMonsters = allMonsters;
        }


    }
}
