using System;
using System.Linq;
using WebApi.DbOperations;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommand{
        
        public UpdateBookModel Model { get; set; }
        public int BookId { get; set; }
        private readonly BookStoreDbContext _context;
        public UpdateBookCommand(BookStoreDbContext context)
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
            ubm.PageCount=Model.PageCount!=default?Model.PageCount:ubm.PageCount;
            ubm.PublishDate=Model.publishDate!=default?Model.publishDate:ubm.PublishDate;
            _context.SaveChanges();
        }
    }
    public class UpdateBookModel{
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime publishDate { get; set; }
        public int GenreId { get; set; }
    }
}
