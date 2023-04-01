using WAD.CW1._00009713.Dto;
using WAD.CW1._00009713.Models;

namespace WAD.CW1._00009713.Interfaces
{
    public interface IBookRepository
    {
        ICollection<Book> GetAll();
        Book GetById(int id);
        Book GetByTitle(string title);
        Book GetBookTrimToUpper(BookDto bookCreate);
        bool IsExist(int id);
        bool CreateBook(int authorId, Book book);
        bool UpdateBook(int authorId, Book book);
        bool DeleteBook(Book book);
        bool Save();
    }
}
