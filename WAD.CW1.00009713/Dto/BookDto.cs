using WAD.CW1._00009713.Models;

namespace WAD.CW1._00009713.Dto
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublicationYear { get; set; }
        public int AuthorId { get; set; }
    }
}
