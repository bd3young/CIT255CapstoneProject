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
        private Monster _detailedAddViewMonster;
        private List<Element.ElementType> _detailedViewElement;
        private List<Location.LocationType> _detailedViewLocation;
        private List<Monster.SpeciesType> _detailedViewType;




        private Element.ElementType _selectedWeaknessElement;
        private Element.ElementType _selectedWeaknessElementUpdate;
        private Element.ElementType _selectedRealElement;
        private Element.ElementType _selectedRealElementUpdate;
        private Location.LocationType _selectedLocation;
        private Location.LocationType _selectedLocationUpdate;
        private Monster.SpeciesType _selectedType;
        private Monster.SpeciesType _selectedTypeUpdate;



        private Element _phMonsterElement;
        private Location _phMonsterLocation;
        private Element _phMonsterRealElement;

        private int _weaknessCount;
        private int _locationCount;
        private int _weaknessCountUpdate;
        private int _locationCountUpdate;

        private MonsterBusiness _monsterBusiness;



        public ICommand ButtonCommand { get; set; }

        bool LocationUpdateBool = true;
        bool WeaknessUpdateBool = true;
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
                OnPropertyChanged("DetailedViewMonster");
            }
        }

        public Monster DetailedAddViewMonster
        {
            get { return _detailedAddViewMonster; }
            set
            {
                if (_detailedAddViewMonster == value)
                {
                    return;
                }
                _detailedAddViewMonster = value;
                OnPropertyChanged("DetailedAddViewMonster");
            }
        }

        public List<Monster.SpeciesType> DetailedViewType
        {
            get { return _detailedViewType; }
            set
            {
                if (_detailedViewType == value)
                {
                    return;
                }
                _detailedViewType = value;
                OnPropertyChanged("DetailedViewType");
            }
        }

        public int WeaknessCount
        {
            get { return _weaknessCount; }
            set
            {
                if (_weaknessCount == value)
                {
                    return;
                }
                _weaknessCount = value;
                OnPropertyChanged("WeaknessCount");
            }
        }

        public int LocationCount
        {
            get { return _locationCount; }
            set
            {
                if (_locationCount == value)
                {
                    return;
                }
                _locationCount = value;
                OnPropertyChanged("LocationCount");
            }
        }

        public int WeaknessCountUpdate
        {
            get { return _weaknessCountUpdate; }
            set
            {
                if (_weaknessCountUpdate == value)
                {
                    return;
                }
                _weaknessCountUpdate = value;
                OnPropertyChanged("WeaknessCountUpdate");
            }
        }

        public int LocationCountUpdate
        {
            get { return _locationCountUpdate; }
            set
            {
                if (_locationCountUpdate == value)
                {
                    return;
                }
                _locationCountUpdate = value;
                OnPropertyChanged("LocationCountUpdate");
            }
        }

        public List<Element.ElementType> DetailedViewElement
        {
            get { return _detailedViewElement; }
            set
            {
                if (_detailedViewElement == value)
                {
                    return;
                }
                _detailedViewElement = value;
                OnPropertyChanged("DetailedViewElement");

            }
        }

        public List<Location.LocationType> DetailedViewLocation
        {
            get { return _detailedViewLocation; }
            set
            {
                if (_detailedViewLocation == value)
                {
                    return;
                }
                _detailedViewLocation = value;
                OnPropertyChanged("DetailedViewLocation");
            }
        }

        public Element.ElementType SelectedWeaknessElement
        {
            get { return _selectedWeaknessElement; }
            set
            {
                if (_selectedWeaknessElement == value)
                {
                    return;
                }
                _selectedWeaknessElement = value;
            }
        }

        public Element.ElementType SelectedWeaknessElementUpdate
        {
            get { return _selectedWeaknessElementUpdate; }
            set
            {
                if (_selectedWeaknessElementUpdate == value)
                {
                    return;
                }
                _selectedWeaknessElementUpdate = value;
            }
        }

        public Location.LocationType SelectedLocation
        {
            get { return _selectedLocation; }
            set
            {
                if (_selectedLocation == value)
                {
                    return;
                }
                _selectedLocation = value;
            }
        }

        public Location.LocationType SelectedLocationUpdate
        {
            get { return _selectedLocationUpdate; }
            set
            {
                if (_selectedLocationUpdate == value)
                {
                    return;
                }
                _selectedLocationUpdate = value;
            }
        }

        public Element.ElementType SelectedRealElement
        {
            get { return _selectedRealElement; }
            set
            {
                if (_selectedRealElement == value)
                {
                    return;
                }
                _selectedRealElement = value;
            }
        }

        public Element.ElementType SelectedRealElementUpdate
        {
            get { return _selectedRealElementUpdate; }
            set
            {
                if (_selectedRealElementUpdate == value)
                {
                    return;
                }
                _selectedRealElementUpdate = value;
            }
        }

        public Monster.SpeciesType SelectedType
        {
            get { return _selectedType; }
            set
            {
                if (_selectedType == value)
                {
                    return;
                }
                _selectedType = value;
            }
        }

        public Monster.SpeciesType SelectedTypeUpdate
        {
            get { return _selectedTypeUpdate; }
            set
            {
                if (_selectedTypeUpdate == value)
                {
                    return;
                }
                _selectedTypeUpdate = value;
            }
        }

        public Element PhMonsterElement
        {
            get { return _phMonsterElement; }
            set
            {
                if (_phMonsterElement == value)
                {
                    return;
                }
                _phMonsterElement = value;

            }
        }

        public Location PhMonsterLocation
        {
            get { return _phMonsterLocation; }
            set
            {
                if (_phMonsterLocation == value)
                {
                    return;
                }
                _phMonsterLocation = value;
            }
        }

        public Element PhMonsterRealElement
        {
            get { return _phMonsterRealElement; }
            set
            {
                if (_phMonsterRealElement == value)
                {
                    return;
                }
                _phMonsterRealElement = value;
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
            ResetDetailedAddViewMonster();
            ResetDetailedElementLocation();
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
                case "ADDWEAKNESS":
                    WeaknessesPressed();
                    break;
                case "ADDLOCATION":
                    LocationsPressed();
                    break;
                case "UPDATEWEAKNESS":
                    WeaknessesPressedUpdate();
                    break;
                case "UPDATELOCATION":
                    LocationsPressedUpdate();
                    break;
                case "SAVETYPE":
                    SaveTypePressed();
                    break;
                case "SAVEELEMENT":
                    SaveElementPressed();
                    break;
                default:
                    break;
            };
        }

        private void SaveElementPressed()
        {
            _phMonsterRealElement = new Element();
            _phMonsterRealElement.MonsterElement = _selectedRealElementUpdate;

            _detailedViewMonster.ElementList = new List<Element>();
            _detailedViewMonster.ElementList.Add(_phMonsterRealElement);
        }

        private void SaveTypePressed()
        {
            _detailedViewMonster.Species = new Monster.SpeciesType();
            _detailedViewMonster.Species = SelectedTypeUpdate;
        }

        private void LocationsPressedUpdate()
        {
            if (_detailedViewMonster.LocationList != null)
            {
                if (LocationUpdateBool)
                {
                    _detailedViewMonster.LocationList = new List<Location>();

                    LocationUpdateBool = false;
                }

                _phMonsterLocation = new Location();

                _phMonsterLocation.MonsterLocation = _selectedLocationUpdate;
                _detailedViewMonster.LocationList.Add(_phMonsterLocation);
                _locationCountUpdate++;
                OnPropertyChanged("LocationCountUpdate");
            }

        }

        private void WeaknessesPressedUpdate()
        {
            if (_detailedViewMonster.WeaknessList != null)
            {
                if (WeaknessUpdateBool)
                {
                    _detailedViewMonster.WeaknessList = new List<Element>();

                    WeaknessUpdateBool = false;
                }

                _phMonsterElement = new Element();

                _phMonsterElement.MonsterElement = _selectedWeaknessElementUpdate;
                _detailedViewMonster.WeaknessList.Add(_phMonsterElement);
                _weaknessCountUpdate ++;
                OnPropertyChanged("WeaknessCountUpdate");
            }
        }

        //
        // add locations to list of locations
        //

        private void LocationsPressed()
        {
            if (_detailedAddViewMonster.LocationList != null)
            {
                _phMonsterLocation = new Location();

                _phMonsterLocation.MonsterLocation = _selectedLocation;
                _detailedAddViewMonster.LocationList.Add(_phMonsterLocation);
                _locationCount = _detailedAddViewMonster.LocationList.Count;
                OnPropertyChanged("LocationCount");
            }

        }

        //
        // add elements to list of weaknesses
        //

        private void WeaknessesPressed()
        {
            if (_detailedAddViewMonster.WeaknessList != null)
            {
                _phMonsterElement = new Element();

                _phMonsterElement.MonsterElement = _selectedWeaknessElement;
                _detailedAddViewMonster.WeaknessList.Add(_phMonsterElement);

                _weaknessCount = _detailedAddViewMonster.WeaknessList.Count;
                OnPropertyChanged("WeaknessCount");

            }
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
            if (_detailedAddViewMonster != null && _detailedAddViewMonster.Name != "")
            {
                _phMonsterRealElement = new Element();
                _phMonsterRealElement.MonsterElement = _selectedRealElement;

                _detailedAddViewMonster.Species = _selectedType;

                _detailedAddViewMonster.ElementList.Add(_phMonsterRealElement);

                _detailedViewMonster = _detailedAddViewMonster;
                _monsterBusiness.AddMonster(_detailedViewMonster);
                _allMonsters.Add(DetailedViewMonster);
                ResetDetailedAddViewMonster();
                _weaknessCount = 0;
                _locationCount = 0;
                OnPropertyChanged("LocationCount");
                OnPropertyChanged("WeaknessCount");
            }
        }

        private void ResetDetailedAddViewMonster()
        {
            _detailedAddViewMonster = new Monster();
            _detailedAddViewMonster.Id = 0;
            _detailedAddViewMonster.Name = "";
            _detailedAddViewMonster.Species = Monster.SpeciesType.Unknown;
            _detailedAddViewMonster.ElementList = new List<Element>();
            _detailedAddViewMonster.WeaknessList = new List<Element>();
            _detailedAddViewMonster.LocationList = new List<Location>();
            _detailedAddViewMonster.ImageFileName = "";
            _detailedAddViewMonster.ImageFilePath = "";
            OnPropertyChanged("DetailedAddViewMonster");

        }

        private void ResetDetailedElementLocation()
        {

            _detailedViewElement = new List<Element.ElementType>();
            _detailedViewElement.Add(Element.ElementType.Dragon);
            _detailedViewElement.Add(Element.ElementType.Fire);
            _detailedViewElement.Add(Element.ElementType.Ice);
            _detailedViewElement.Add(Element.ElementType.None);
            _detailedViewElement.Add(Element.ElementType.Thunder);
            _detailedViewElement.Add(Element.ElementType.Unknown);
            _detailedViewElement.Add(Element.ElementType.Water);

            _detailedViewLocation = new List<Location.LocationType>();
            _detailedViewLocation.Add(Location.LocationType.AncientForest);
            _detailedViewLocation.Add(Location.LocationType.CoralHighlands);
            _detailedViewLocation.Add(Location.LocationType.EldersRecess);
            _detailedViewLocation.Add(Location.LocationType.RottenVale);
            _detailedViewLocation.Add(Location.LocationType.TheGuidingLands);
            _detailedViewLocation.Add(Location.LocationType.Unknown);
            _detailedViewLocation.Add(Location.LocationType.WildspireWaste);

            _detailedViewType = new List<Monster.SpeciesType>();
            _detailedViewType.Add(Monster.SpeciesType.BirdWyvern);
            _detailedViewType.Add(Monster.SpeciesType.BruteWyvern);
            _detailedViewType.Add(Monster.SpeciesType.ElderDragon);
            _detailedViewType.Add(Monster.SpeciesType.FangedWyvern);
            _detailedViewType.Add(Monster.SpeciesType.FlyingWyvern);
            _detailedViewType.Add(Monster.SpeciesType.PiscineWyvern);
            _detailedViewType.Add(Monster.SpeciesType.Unknown);
        }

        private void UpdatePressed()
        {
            if (_detailedViewMonster != null)
            {
                if (_selectedMonster.Id == _detailedViewMonster.Id)
                {
                    Monster monsterToUpdate = _allMonsters.FirstOrDefault(c => c.Id == SelectedMonster.Id);

                    if (monsterToUpdate != null)
                    {

                        _monsterBusiness.UpdateMonster(DetailedViewMonster);
                        _allMonsters.Remove(monsterToUpdate);
                        _allMonsters.Add(DetailedViewMonster);

                        _weaknessCount = 0;
                        _locationCount = 0;
                        OnPropertyChanged("LocationCount");
                        OnPropertyChanged("WeaknessCount");
                        OnPropertyChanged("DetailedViewMonster");
                        LocationUpdateBool = true;
                        WeaknessUpdateBool = true;
                    }
                }

            }

        }

        private void DeletePressed()
        {
            if (_selectedMonster != null)
            {
                UpdateDetailedViewCharacterToSelected();
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show($" Are you sure you want to delete {SelectedMonster.Name} from your Monster Dex?", "Delete Monster", System.Windows.MessageBoxButton.OKCancel);

                if (messageBoxResult == MessageBoxResult.OK)
                {

                    _monsterBusiness.DeleteMonster(SelectedMonster.Id);
                    _allMonsters.Remove(_selectedMonster);

                }
            }
        }

        #endregion












    }
}
