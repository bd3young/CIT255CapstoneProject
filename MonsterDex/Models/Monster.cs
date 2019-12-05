using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MonsterDex.Models
{
    public class Monster : ObservableObject
    {
        #region ENUMS

        public enum SpeciesType { FangedWyvern, BirdWyvern, BruteWyvern, PiscineWyvern, FlyingWyvern, ElderDragon, Unknown }

        private Dictionary<string, SpeciesType> BinaryOperations = new Dictionary<string, SpeciesType>()
        {
            { "Fanged Wyvern", SpeciesType.FangedWyvern },
            { "Bird Wyvern", SpeciesType.BirdWyvern },
            { "Brute Wyvern", SpeciesType.BruteWyvern },
            { "Piscine Wyvern", SpeciesType.PiscineWyvern },
            { "Flying Wyvern", SpeciesType.FlyingWyvern },
            { "Elder Dragon", SpeciesType.ElderDragon },
        };

        #endregion

        #region FIELDS

        private int _id;
        private string _name;
        private SpeciesType _species;
        private List<Element> _elementList;
        private List<Element> _weaknessList;
        private List<Location> _locationList;
        private string _imageFileName;
        private string _imageFilePath;
        private ObservableCollection<Monster> _monsters;
        //private Element _monsterElement;



        #endregion

        #region PROPERTIES

        public int Id
        {   
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public SpeciesType Species
        {
            get { return _species; }
            set { _species = value; }
        }

        public List<Element> ElementList
        {
            get { return _elementList; }
            set { _elementList = value; }
        }

        public List<Element> WeaknessList
        {
            get { return _weaknessList; }
            set { _weaknessList = value; }
        }   

        public List<Location> LocationList
        {
            get { return _locationList; }
            set { _locationList = value; }
        }   

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }  

        public string ImageFilePath
        {
            get { return _imageFilePath; }
            set { _imageFilePath = value; }
        }

        public ObservableCollection<Monster> Monsters
        {
            get { return _monsters; }
            set { _monsters = value; }
        }

        //public Element MonsterElement
        //{
        //    get { return _monsterElement; }
        //    set { _monsterElement = value; }
        //}


        #endregion

        #region CONSTRUCTORS

        public Monster()
        {

        }

        #endregion

        #region METHODS

        #endregion

        #region EVENTS

        #endregion
    }
}
