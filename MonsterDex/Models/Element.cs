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


        private ElementType _monsterElement;

        public ElementType MonsterElement
        {
            get { return _monsterElement; }
            set { _monsterElement = value; }    
        }



        #endregion
    }
}
