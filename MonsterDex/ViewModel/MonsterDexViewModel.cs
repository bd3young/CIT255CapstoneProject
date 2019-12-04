using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using System.Collections;
using System.Windows;
using System.Windows.Input;
using MonsterDex.BusinessLayer;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MonsterDex.DataLayer;
using MonsterDex.PresentationLayer;

namespace MonsterDex.ViewModel
{
    public class MonsterDexViewModel : ObservableObject
    {

        #region ENUM

        #endregion

        #region PROPERTIES

        private ObservableCollection<Monster> _allMonsters;

        private Monster _selectedMonster;
		private Monster _detailedViewMonster;

		

		private MonsterBusiness _monsterBusiness;



		public ICommand ButtonCommand { get; set; }


        #endregion

        #region FIELDS



        public ObservableCollection<Monster> AllMonsters
        {
            get { return _allMonsters; }
            set { _allMonsters = value; }
        }

        public Monster SelectedMonster
        {
            get { return _selectedMonster; }
            set
			{
				if (_selectedMonster == value)
				{
					return;
				}
				_selectedMonster = value;
				
			}
        }

		public Monster DetailedViewMonster
		{
			get { return _detailedViewMonster; }
			set
			{
				if (_detailedViewMonster == value)
				{
					return;
				}
				_detailedViewMonster = value;
				OnPropertyChanged("DetailedViewCharacter");
			}
		}

		#endregion

		#region CONSTRUCTORS

		public MonsterDexViewModel()
		{

		}

		public MonsterDexViewModel(MonsterBusiness monsterBuissness)
		{

			_monsterBusiness = monsterBuissness;
			_allMonsters = new ObservableCollection<Monster>(monsterBuissness.AllMonsters());
			UpdateImagePath();
			ButtonCommand = new RelayCommand(new Action<Object>(ButtonPressed));

		}

		private void UpdateImagePath()
		{
			foreach (var monster in _allMonsters)
			{
				monster.ImageFilePath = DataConfig.ImagePath + monster.ImageFileName;
			}
		}

		#endregion

		#region METHODS

		public void InitializeViewModel(MonsterBusiness monsterBusiness)
        {
			_monsterBusiness = monsterBusiness;

            


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


			if (_selectedMonster != null)
			{
				UpdateDetailedViewCharacterToSelected();
			}
		}

		private void UpdateDetailedViewCharacterToSelected()
		{
			_detailedViewMonster = new Monster();
			_detailedViewMonster.Id = _selectedMonster.Id;
			_detailedViewMonster.Name = _selectedMonster.Name;
			_detailedViewMonster.Species = _selectedMonster.Species;
			_detailedViewMonster.ElementList = _selectedMonster.ElementList;
			_detailedViewMonster.WeaknessList = _selectedMonster.WeaknessList;
			_detailedViewMonster.LocationList = _selectedMonster.LocationList;
			_detailedViewMonster.ImageFileName = _selectedMonster.ImageFileName;
			_detailedViewMonster.ImageFilePath = _selectedMonster.ImageFilePath;
			OnPropertyChanged("DetailedViewMonster");
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
