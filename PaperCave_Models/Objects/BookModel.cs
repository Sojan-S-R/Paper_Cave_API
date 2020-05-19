using PaperCave_Models.Enums;

namespace PaperCave_Models.Objects
{
    public class BookModel
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public AuthorModel Author { get; set; }
        public AverageRatings Rating { get; set; }
        public PublisherModel Publisher { get; set; }
    }
}
