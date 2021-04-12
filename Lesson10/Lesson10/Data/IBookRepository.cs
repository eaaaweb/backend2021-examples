using Lesson10.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson10.Data
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBookList();
        Book GetBookById(int id);
        void SaveBook(Book book);
        Book DeleteBook(int bookId);
        bool BookExists(int id);
        List<Author> GetAuthorList();
        List<SelectListItem> GetAuthorSelectList();

    }
}