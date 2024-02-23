using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class BookDetails
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public DateTime BookReleaseDate { get; set; }
        public string BookDescription { get; set; }
        public string Genre { get; set; }
        public string BookPublisher { get; set; }
        public decimal BookPrice { get; set; }
    }
}
