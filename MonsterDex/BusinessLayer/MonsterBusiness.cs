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
		bool _xmlBool = true;

		public MonsterBusiness()
		{



		}

        private Monster GetMonster(int id)
        {
            Monster monster = null;
            FileIoStatus = FileIoMessage.None;

            try
            {
                using (MonstersRepository monstersRepository = new MonstersRepository())
                {
                    monster = monstersRepository.GetById(id);
                };

                if (monster != null)
                {
                    FileIoStatus = FileIoMessage.Complete;
                }
                else
                {
                    FileIoStatus = FileIoMessage.RecordNotFound;
                }
            }
            catch (Exception)
            {
                FileIoStatus = FileIoMessage.FileAccessError;
            }

            return monster;
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

        public void AddMonster(Monster monster)
        {
            try
            {
                if (monster != null)
                {
                    using (MonstersRepository monstersRepository = new MonstersRepository())
                    {
                        monstersRepository.Add(monster);
                    };

                    FileIoStatus = FileIoMessage.Complete;
                }
            }
            catch (Exception)
            {
                FileIoStatus = FileIoMessage.FileAccessError;
            }
        }

        public void UpdateMonster(Monster updatedMonster)
        {
            try
            {
                if (GetMonster(updatedMonster.Id) != null)
                {
                    using (MonstersRepository repo = new MonstersRepository())
                    {
                        repo.Update(updatedMonster);
                    }

                    FileIoStatus = FileIoMessage.Complete;
                }
                else
                {
                    FileIoStatus = FileIoMessage.RecordNotFound;
                }
            }
            catch (Exception)
            {
                FileIoStatus = FileIoMessage.FileAccessError;
            }
        }

        public Monster MonsterById(int id)
        {
            return GetMonster(id);
        }

        public void DeleteMonster(int id)
        {
            try
            {
                if (GetMonster(id) != null)
                {
                    using (MonstersRepository repo = new MonstersRepository())
                    {
                        repo.Delete(id);
                    }

                    FileIoStatus = FileIoMessage.Complete;
                }
                else
                {
                    FileIoStatus = FileIoMessage.RecordNotFound;
                }
            }
            catch (Exception)
            {
                FileIoStatus = FileIoMessage.FileAccessError;
            }

        }
    }
}
