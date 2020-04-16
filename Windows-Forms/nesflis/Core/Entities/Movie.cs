namespace Core.Entities
{
    public class Movie
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public Genre[] Genres { get; set; }
        public string[] Actors { get; set; }
        public int PercentageRate { get; set; }
    }
}
