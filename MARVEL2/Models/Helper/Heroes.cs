using MARVEL2.Controllers;

namespace MARVEL2.Models.Helper
{
    public static class Heroes
    {
        
        public static List<Hero> GetAll()
        {
            return new List<Hero>
            {
                new Hero() { HeroName = "IronMan"},
                new Hero() { HeroName = "Spiderman"},
                new Hero() { HeroName = "Captain America"},
                new Hero() { HeroName = "Captain Marvel"},
                new Hero() { HeroName = "Ms Marvel"},
                new Hero() { HeroName = "Hulk"},
                new Hero() { HeroName = "Black Window"},
                new Hero() { HeroName = "Hawkeye"},
                new Hero() { HeroName = "Black Panther"},
                new Hero() { HeroName = "Doctor Strange"},
                new Hero() { HeroName = "Ant-Man"},
                new Hero() { HeroName = "The Wasp"},
                new Hero() { HeroName = "Vision"},
                new Hero() { HeroName = "Falcon"},
                new Hero() { HeroName = "Winter Soldier"},
                new Hero() { HeroName = "Scarlet Witch"},
                new Hero() { HeroName = "Fury"},
                new Hero() { HeroName = "Star Lord"},
                new Hero() { HeroName = "Gamora"},
                new Hero() { HeroName = "Nebula"},
                new Hero() { HeroName = "Rocket"},
                new Hero() { HeroName = "Drax"},
                new Hero() { HeroName = "Groot"},
                new Hero() { HeroName = "Mantis"},
                new Hero() { HeroName = "ShangChi"},

            };
        }

        internal static IEnumerable<object> GetIEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
