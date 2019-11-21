using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
    class Element
    {
        #region ENUM

        public enum ElementType { Fire, Water, Ice, Thunder, Dragon }

        #endregion

        #region FEILDS

        public ElementType Name { get; set; }   

        #endregion
    }
}
