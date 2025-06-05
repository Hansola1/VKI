namespace MorphpediaAPI.Models
{
    public class Morph
    {
        public Morph(string title, string description, string imagePath, string yearOpening, string type) 
        {
            Title = title;
            Description = description;
            ImagePath = imagePath;
            YearOpening = yearOpening;
            Type = type;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string YearOpening { get; set; }
        public string Type { get; set; }
    }
}
