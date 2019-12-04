using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using MonsterDex.Models;
using MonsterDex.DataLayer;

namespace MonsterDex.DataLayer
{
    class DataServiceXml : IDataService
    {

        private string _dataFilePath;

        public IEnumerable<Monster> ReadAll()
        {
            List<Monster> monsters = new List<Monster>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Monster>));

            try
            {
                StreamReader reader = new StreamReader(_dataFilePath);
                using (reader)
                {
                    monsters = (List<Monster>)serializer.Deserialize(reader);
                }

            }
            catch (Exception)
            {
                throw;
            }

            return monsters;
        }

        public void WriteAll(IEnumerable<Monster> monsters)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Monster>), new XmlRootAttribute("Monsters"));

            try
            {
                StreamWriter writer = new StreamWriter(_dataFilePath);
                using (writer)
                {
                    serializer.Serialize(writer, monsters);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataServiceXml()
        {
            _dataFilePath = DataConfig.DataPathXml;
        }
    }
}
