using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.Application.Commands.BookOperations.UpdateBook
{
    public class UpdateBookCommand{
        
        public UpdateBookModel Model { get; set; }
        public int BookId { get; set; }
        private readonly IBookStoreDbContext _context;
        public UpdateBookCommand(IBookStoreDbContext context)
        {
            _context=context;
        }
        public void Handle(){
            var ubm = _context.Books.SingleOrDefault(x => x.Id == BookId);
            if(ubm is null)
            {
                throw new InvalidOperationException("Kitap Bulunamadi");
            }
            ubm.Title=Model.Title!=default ? Model.Title:ubm.Title;
            ubm.GenreId=Model.GenreId!=default?Model.GenreId:ubm.GenreId;
            _context.SaveChanges();
        }
    }
    public class UpdateBookModel{
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}
