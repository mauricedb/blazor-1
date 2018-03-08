namespace WebApplication1.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public string PosterPathW300
        {
            get
            {
                return "//image.tmdb.org/t/p/w300" + this.poster_path;
            }
        }
    }

    public class MovieDetail : Movie
    {
        public decimal vote_average { get; set; }
        public Genre[] genres { get; set; }
    }

   public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
