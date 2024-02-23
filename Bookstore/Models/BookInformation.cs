namespace Bookstore.Models
{
    public class BookInformation
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookAuthor {  get; set; }
        public DateTime BookReleaseDate { get; set; }
        public string BookDescription { get; set; }
        public string Genre { get; set; }
        public string BookPublisher { get; set; }
        public float BookPrice { get; set; }
    }
}
