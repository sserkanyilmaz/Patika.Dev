
using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand {
        private readonly BookStoreDbContext _context;
        public int AuthorId { get; set; }
        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.AuthorId==AuthorId);
            if(author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            var authorsBook = _context.Books.Where(x => x.AuthorId == AuthorId).Any();
            if (authorsBook)
                throw new InvalidProgramException("Yazarın hali hazırda kitabı vardır");

            _context.Remove(author);
            _context.SaveChanges();
        }
    }
}
