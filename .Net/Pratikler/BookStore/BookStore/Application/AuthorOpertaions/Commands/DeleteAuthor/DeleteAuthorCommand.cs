
using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand {
        private readonly IBookStoreDbContext _context;
        public int AuthorId { get; set; }
        public DeleteAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.AuthorId==AuthorId);
            if(AuthorId<=0)
            {
                throw new InvalidOperationException("Geçersiz id girişi yapıldı");
            }
            if(author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            var authorsBook = _context.Books.Where(x => x.AuthorId == AuthorId).Any();
            if (authorsBook)
                throw new InvalidProgramException("Yazarın hali hazırda kitabı vardır");

            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
    }
}
