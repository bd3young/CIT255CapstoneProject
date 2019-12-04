using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.DataLayer
{
    public class DataConfig
    {

        public static DataType dataType = DataType.XML;
        //public static DataType dataType = DataType.SEED;

        public static string DataPathXml;
		public static string ImagePath => @"\DataLayer\Media\";

        //public static string DataPathSeed = MonsterSeedData.GenerateListOfMonsters;

    }
}
