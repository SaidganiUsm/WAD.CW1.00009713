namespace WAD.CW1._00009713.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime BirthDate { get; set; }
        public int BooksCount { get; set; }
        public ICollection<Book> Books { get; set;}
    }
}
