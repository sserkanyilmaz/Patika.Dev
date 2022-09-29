using System;
using System.Linq;
using WebApi.Common;
using WebApi.DbOperations;

namespace Web.BookOperations.GetById{
    public class GetByIdCommand{
        public BookDetailModel Model {get; set;}
        public int BookId {get; set;}
        private readonly BookStoreDbContext _context;
        public GetByIdCommand(BookStoreDbContext context)
        {
            _context=context;
        } 
        public BookDetailModel Handle(){
            var book = _context.Books.Where(x => x.Id == BookId).SingleOrDefault();
            if(book is null)
                {
                    throw new InvalidOperationException("Kitap bulunamadı");
                }
            BookDetailModel bm = new BookDetailModel();
            bm.Title=book.Title;
            bm.PageCount = book.PageCount;
            bm.Genre=((GenreEnum)book.GenreId).ToString();
            bm.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy");
            return bm;
        }
    }
    public class BookDetailModel{
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string PublishDate { get; set; }
    }
}