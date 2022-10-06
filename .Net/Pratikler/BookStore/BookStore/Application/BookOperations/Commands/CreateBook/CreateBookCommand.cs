using System;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.Commands.BookOperations.CreateBook{
    public class CreateBookCommand{
        public CreateBookModel Model {get; set;}
        private readonly IMapper _mapper;
        private readonly IBookStoreDbContext _context;
        public CreateBookCommand(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Title == Model.Title);
            if (book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut");
            }
            book=_mapper.Map<Book>(Model);//new Book();

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