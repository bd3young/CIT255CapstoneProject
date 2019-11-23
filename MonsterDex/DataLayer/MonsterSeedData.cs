using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterDex.Models;

namespace MonsterDex.DataLayer
{
    class MonsterSeedData
    {
        public static List<Monster> GenerateListOfMonsters()
        {
            List<Monster> monsters = new List<Monster>()
            {
            new Monster()
            {
                Id = 1,
                Name = "Rathalos",
                Species = Monster.SpeciesType.FlyingWyvern,
                Element = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Thunder
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Water
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Ice
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.EldersRecess
                    }
                },
                ImageFileName = "rathalos.png"
            },

            new Monster()
            {
                Id = 2,
                Name = "Rathian",
                Species = Monster.SpeciesType.FlyingWyvern,
                Element = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Thunder
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.WildspireWaste
                    }
                },
                ImageFileName = "rathian.png"
            },

            new Monster()
            {
                Id = 3,
                Name = "Brachydios",
                Species = Monster.SpeciesType.BruteWyvern,
                Element = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.None
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Water
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Thunder
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Dragon
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.EldersRecess
                    }
                },
                ImageFileName = "brachydios.png"
            },

            new Monster()
            {
                Id = 4,
                Name = "Zinogre",
                Species = Monster.SpeciesType.FangedWyvern,
                Element = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Thunder
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Water
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Fire
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Dragon
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.CoralHighlands
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.TheGuidingLands
                    }
                },
                ImageFileName = "zinogre.png"
            },

            new Monster()
            {
                Id = 5,
                Name = "Glavenus",
                Species = Monster.SpeciesType.BruteWyvern,
                Element = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Water
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        MonsterElement = Element.ElementType.Thunder
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.WildspireWaste
                    },
                    new Location()
                    {
                        MonsterLocation = Location.LocationType.EldersRecess
                    }
                },
                ImageFileName = "glavenus.png"
            }
            };
            return monsters;
        }
    }
}
