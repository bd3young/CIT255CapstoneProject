using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;
using MonsterDex.DataLayer;
using MonsterDex.DataLayer.Repository;
using MonsterDex.PresentationLayer;

namespace MonsterDex.BusinessLayer
{
	public class MonsterBusiness
	{
		public FileIoMessage FileIoStatus { get; set; }
		bool _xmlBool = false;

		public MonsterBusiness()
		{



		}

		public List<Monster> AllMonsters()
		{
			return GetAllMonsters() as List<Monster>;
		}

		private List<Monster> GetAllMonsters()
		{
			List<Monster> monsters = null;
			FileIoStatus = FileIoMessage.None;
			if (_xmlBool)
			{
				try
				{
					using (MonstersRepository monstersRepository = new MonstersRepository())
					{
						monsters = monstersRepository.GetAll() as List<Monster>;
					};

					if (monsters != null)
					{
						FileIoStatus = FileIoMessage.Complete;
					}
					else
					{
						FileIoStatus = FileIoMessage.NoRecordsFound;
					}
				}
				catch (Exception)
				{
					FileIoStatus = FileIoMessage.FileAccessError;
				}
			}
			else
			{
				monsters = MonsterSeedData.GenerateListOfMonsters();
			}

			return monsters;
		}
	}
}
