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
        public static List<Monster> monsters = new List<Monster>()
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
                        Name = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        Name = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Thunder
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Water
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Ice
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        Name = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        Name = Location.LocationType.EldersRecess
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
                        Name = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        Name = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Thunder
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        Name = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        Name = Location.LocationType.WildspireWaste
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
                        Name = Element.ElementType.None
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        Name = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Water
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Thunder
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Dragon
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        Name = Location.LocationType.EldersRecess
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
                        Name = Element.ElementType.Thunder
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        Name = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Water
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Fire
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Dragon
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        Name = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        Name = Location.LocationType.CoralHighlands
                    },
                    new Location()
                    {
                        Name = Location.LocationType.TheGuidingLands
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
                        Name = Element.ElementType.Fire
                    }
                },
                Weakness = new List<Element>()
                {
                    new Element()
                    {
                        Name = Element.ElementType.Water
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Ice
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Dragon
                    },
                    new Element()
                    {
                        Name = Element.ElementType.Thunder
                    }
                },
                Location = new List<Location>()
                {
                    new Location()
                    {
                        Name = Location.LocationType.AncientForest
                    },
                    new Location()
                    {
                        Name = Location.LocationType.WildspireWaste
                    },
                    new Location()
                    {
                        Name = Location.LocationType.EldersRecess
                    }
                },
                ImageFileName = "glavenus.png"
            }
        };
    }
}
