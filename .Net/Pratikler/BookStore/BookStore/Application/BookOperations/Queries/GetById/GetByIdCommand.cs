using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi;
using WebApi.Common;
using WebApi.DbOperations;

namespace Web.Application.Queries.BookOperations.GetById{
    public class GetByIdQuery{
        public BookDetailModel Model {get; set;}
        public int BookId {get; set;}
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetByIdQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public BookDetailModel Handle(){
            var book = _context.Books.Include(x=>x.Genre).Where(x => x.Id == BookId).SingleOrDefault();
            if(book is null)
                {
                    throw new InvalidOperationException("Kitap bulunamadı");
                }
            BookDetailModel bm = _mapper.Map<BookDetailModel>(book);
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