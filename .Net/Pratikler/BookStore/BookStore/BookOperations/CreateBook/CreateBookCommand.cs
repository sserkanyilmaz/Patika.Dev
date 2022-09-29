using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.DbOperations;

namespace WebApi.BookOperations.CreateBook{
    public class CreateBookCommand{
        public CreateBookModel Model {get; set;}
        private readonly BookStoreDbContext _context;
        public CreateBookCommand(BookStoreDbContext context)
        {
            _context=context;
        }
        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Title == Model.Title);
            if (book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut");
            }
            book=new Book();
            book.Title=Model.Title;
            book.PageCount=Model.PageCount;
            book.PublishDate=Model.PublishDate;
            book.GenreId=Model.GenreId;
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
    public class CreateBookModel{
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int GenreId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}