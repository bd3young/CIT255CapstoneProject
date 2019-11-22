using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
    public class Location
    {

        #region ENUM

        public enum LocationType { AncientForest, WildspireWaste, CoralHighlands, RottenVale, EldersRecess, TheGuidingLands }

        private Dictionary<string, LocationType> BinaryOperations = new Dictionary<string, LocationType>()
        {
            { "Ancient Forest", LocationType.AncientForest },
            { "Wildspire Waste", LocationType.WildspireWaste },
            { "Coral Highlands", LocationType.CoralHighlands },
            { "Rotten Vale", LocationType.RottenVale },
            { "Elder's Recess", LocationType.EldersRecess },
            { "The Guiding Lands", LocationType.TheGuidingLands },
        };

        #endregion

        #region FEILDS

        public LocationType Name { get; set; }  

        #endregion

    }
}
