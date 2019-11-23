using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using System.Collections;
using System.Windows.Input;

namespace MonsterDex.PresentationLayer
{
    public class MonsterDexViewModel : ObservableObject
    {

        #region ENUM

        #endregion

        #region PROPERTIES

        private List<Monster> _allMonsters;
        private List<string> _monsterName;
        private List<int> _monsterId;

        private Monster _currentMonster;

        public ICommand ButtonCommand { get; set; }


        #endregion

        #region FIELDS



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

        public List<int> MonsterId
        {
            get { return _monsterId; }
            set { _monsterId = value; }
        }   

        public Monster CurrentMonster
        {
            get { return _currentMonster; }
            set { _currentMonster = value; }
        }   

        #endregion

        #region CONSTRUCTORS

        public MonsterDexViewModel(List<Monster> allMonsters, List<int> monsterId, List<string> monsterName)
        {
            InitializeViewModel( allMonsters, monsterId, monsterName);
        }

        #endregion

        #region METHODS

        public void InitializeViewModel(List<Monster> allMonsters, List<int> monsterId, List<string> monsterName)
        {   
            _allMonsters = allMonsters;
            _monsterId = monsterId;
            _monsterName = monsterName;

            ButtonCommand = new RelayCommand(new Action<Object>(ButtonPressed));


        }

        private void ButtonPressed(object obj)
        {
            switch (obj.ToString())
            {
                case "View":
                    ViewPressed();
                    break;
                case "Add":
                    AddPressed();
                    break;
                case "Update":
                    UpdatePressed();
                    break;
                case "Delete":
                    DeletePressed();
                    break;
                default:
                    break;
            };
        }

        private void ViewPressed()
        {
            //if ()
            //{

            //}
        }

        private void AddPressed()
        {
            throw new NotImplementedException();
        }

        private void UpdatePressed()
        {
            throw new NotImplementedException();
        }

        private void DeletePressed()
        {
            throw new NotImplementedException();
        }

        #endregion












    }
}
