using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.Application.Commands.BookOperations.DeleteBook
{
    public class DeleteBookCommand {
        private readonly IBookStoreDbContext _context;
        public int BookId { get; set; }
        public DeleteBookCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle(){
            var book = _context.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
            { throw new InvalidOperationException("Kitap Bulunamadi"); }
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

    }
}