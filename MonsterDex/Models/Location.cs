using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
    class Location
    {

        #region ENUM

        public enum LocationType { AncientForest, WildspireWaste, CoralHighlands, RottenVale, EldersRecess, TheGuidingLands }

        #endregion

        #region FEILDS

        public LocationType Name { get; set; }  

        #endregion

    }
}
