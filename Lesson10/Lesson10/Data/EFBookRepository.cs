using Lesson10.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson10.Data
{
    public class EFBookRepository : IBookRepository
    {
        private readonly BookContext dataContext;

        public EFBookRepository(BookContext context)
        {
            dataContext = context;
        }

        public async Task<IEnumerable<Book>> GetBookList()
        {
            return await dataContext.Books.Include(b => b.Author).ToListAsync();
        }

        public Book GetBookById(int id)
        {
            return dataContext.Books.Find(id);
        }

        public void SaveBook(Book book)
        {
            if (book.BookId == 0)
            {
                dataContext.Books.Add(book);
                dataContext.SaveChanges();
            }
            else
            {
                dataContext.Entry(book).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public Book DeleteBook(int bookId)
        {
            Book book = dataContext.Books.Find(bookId);
            dataContext.Books.Remove(book);
            dataContext.SaveChanges();
            return book;
        }


        public bool BookExists(int id)
        {
            return dataContext.Books.Any(e => e.BookId == id);
        }

        public List<Author> GetAuthorList()
        {
            return dataContext.Authors.ToList();
        }

        public List<SelectListItem> GetAuthorSelectList()
        {
            List<SelectListItem> selectList = new List<SelectListItem>();
            var authors = dataContext.Authors.ToList();

            foreach (Author author in authors)
            {
                selectList.Add(new SelectListItem { Value = author.AuthorId.ToString(), Text = author.Name });
            }
            return selectList;
        }
    }
}
