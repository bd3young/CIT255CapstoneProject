using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDex.Models
{
    public class Element
    {
        #region ENUM

        public enum ElementType { Fire, Water, Ice, Thunder, Dragon, None, Unknown }

        #endregion

        #region FEILDS

        public ElementType MonsterElement { get; set; }   

        #endregion
    }
}
