namespace MARVEL2.Models
{
    public class Villan
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Abilities { get; set; }
        public string? OriginPlanet { get; set; }
    }

    public static class Villans
    {
        public static List<Villan> GetAll()
        {
            return new List<Villan>
            {
                new Villan() { Name = "Obadiah Stane/Iron Monger"},//Iron Man
                new Villan() { Name = "Ivan Vanko/Whiplash"},//Iron Man 2
                new Villan() { Name = "Aldrich Killian"},//Iron Man 3
                new Villan() { Name = "Emil Blonsky/Abomination"},//The Incredible Hulk
                new Villan() { Name = "Darren Cross/Yellowjacket"},//Ant-Man
                new Villan() { Name = "Ava Starr/Ghost"},//Ant-Man and the Wasp
                new Villan() { Name = "Kang the Conqueror"},//Ant-Man and the Wasp: Quantumania      
                new Villan() { Name = "Dreykov"},//Black Widow
                new Villan() { Name = "Johann Schmidt/Red Skull"},//Captain America
                new Villan() { Name = "Alexander Pierce"},//Captain America: The Winter Soldier
                new Villan() { Name = "Zemo"},//Captain America: Civil War
                new Villan() { Name = "Kaecilius"},//Doctor Strange
                new Villan() { Name = "Ikaris"},//Eternals
                new Villan() { Name = "Yon-Rogg"},//Captain Marvel
                new Villan() { Name = "Adrian Toomes/Vulture"},//Spider-Man: Homecoming                
                new Villan() { Name = "Quentin Beck/Mysterio"},//Spider-Man: Far From Home
                new Villan() { Name = "Norman Osborn/Green Goblin"},//Spider-Man: No Way Home
                new Villan() { Name = "Scarlet Witch"},//Doctor Strange in the Multiverse of Madness
                new Villan() { Name = "Ultron"},//Avengers: Age of Ultron
                new Villan() { Name = "Thanos"},//Avengers: Infinity War, Avengers: Endgame
                new Villan() { Name = "Loki"},//Thor, The Avengers
                new Villan() { Name = "Malekith"},//Thor: The Dark World
                new Villan() { Name = "Hela"},//Thor: Ragnarok
                new Villan() { Name = "Gorr the God Butcher"},//Thor: Love and Thunder               
                new Villan() { Name = "Ronan"},//Guardians of the Galaxy
                new Villan() { Name = "Ego"},//Guardians of the Galaxy Vol 2
                new Villan() { Name = "The High Evolutionary"},//Guardians of the Galaxy Vol. 3
                new Villan() { Name = "Wenwu/The Mandarin"},//Shang-Chi and the Legend of the Ten Rings
                new Villan() { Name = "N’Jadaka/Erik Killmonger"},//Black Panther
                new Villan() { Name = "Namor"},//Black Panther: Wakanda Forever
                new Villan() { Name = "Agatha Harkness"},//Wanadvision
                new Villan() { Name = "Maya Lopez/Echo"},//Hawkeye
                new Villan() { Name = "Kang"},//Loki Season 1
                new Villan() { Name = "Karli Morgenthau/Flag-Smasher"},//Falcon and Winter Soldier
                new Villan() { Name = "Taneleer Tivan/The Collector"},// What if....?
                new Villan() { Name = "Arthur Harrow"},//Moon Knoght
                new Villan() { Name = "Najma"},//Ms Marvel
                new Villan() { Name = "Todd Phelps/HulkKing"},//She Hulk
                new Villan() { Name = "Moon Knight"},//Werewolf By Night
                new Villan() { Name = "Kingsley Ben-Adir"},//Secret Invasion
            };
        }
    }



}
