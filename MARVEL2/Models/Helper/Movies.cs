using MARVEL2.Models;

namespace MARVEL2.Models.Helper
{
    public static class Movies
    {
        public static List<Movie> GetAll()
        {
            return new List<Movie>
            {
                new Movie() { Name = "Iron Man"},
                new Movie() { Name = "IronMan2"},
                new Movie() { Name = "IronMan3"},
                new Movie() { Name = "Captain America"},
                new Movie() { Name = "CaptainAmerica Winter Soldier"},
                new Movie() { Name = "CaptainAmerica Civil War"},
                new Movie() { Name = "Hulk"},
                new Movie() { Name = "Black Widow"},
                new Movie() { Name = "Gardians of The Galaxy"},
                new Movie() { Name = "Gardians of The Galaxy Vol. 2"},
                new Movie() { Name = "Gardians of The Galaxy Vol. 3"},
                new Movie() { Name = "Thor"},
                new Movie() { Name = "Ant-Man"},
                new Movie() { Name = "Ant-Man And The Wasp"},
                new Movie() { Name = "Ant-Man And The Wasp: Quantumania"},
                new Movie() { Name = "Doctor Strange"},
                new Movie() { Name = "Doctor Strange: Multivers Of Madness"},
                new Movie() { Name = "Spiderman Homecomming"},
                new Movie() { Name = "Spiderman: Far From Home"},
                new Movie() { Name = "Spiderman: No Way Home"},
                new Movie() { Name = "Black Panther"},
                new Movie() { Name = "Black Panther: Wakanda Forever"},
                new Movie() { Name = "Captain Marvel"},
                new Movie() { Name = "The Marvels"},
                new Movie() { Name = "Avengers"},
                new Movie() { Name = "Avengers: Age Of Ultron"},
                new Movie() { Name = "Avengers: Infinity War"},
                new Movie() { Name = "Avengers: EndGame "},
                new Movie() { Name = "ShangChi"},
                new Movie() { Name = "Eternals"},
            };
        }
    }
}
