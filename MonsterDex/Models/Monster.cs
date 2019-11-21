using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
    class Monster
    {
        #region ENUMS

        public enum SpeciesType { FangedWyvern, BirdWyvern, BruteWyvern, PiscineWyvern, FlyingWyvern, ElderDragon }

        #endregion

        #region FIELDS

        private int _id;
        private string _name;
        private SpeciesType _species;
        private List<Element> _element;
        private List<Element> _weakness;
        private List<Location> _location;
        private string _imageFileName;
        private string _imageFilePath;


   

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

        public List<Element> Element
        {
            get { return _element; }
            set { _element = value; }
        }

        public List<Element> Weakness
        {
            get { return _weakness; }
            set { _weakness = value; }
        }   

        public List<Location> Location
        {
            get { return _location; }
            set { _location = value; }
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
