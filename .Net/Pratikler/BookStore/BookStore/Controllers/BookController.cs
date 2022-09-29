using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web.BookOperations.GetById;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.UpdateBook;
using WebApi.DbOperations;

namespace WebApi.AddControllers{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase{
        private readonly BookStoreDbContext _context;
        public BookController(BookStoreDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookDetailModel result;
            try
            {
                GetByIdCommand query = new GetByIdCommand(_context);
                query.BookId=id;
                result=query.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand createBookCommand = new CreateBookCommand(_context);
            try
            {
                createBookCommand.Model = newBook;
                createBookCommand.Handle();
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
            return Ok();


        }
        //put
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id ,[FromBody] UpdateBookModel updatedBook )
        {
            UpdateBookCommand updateBookCommand = new UpdateBookCommand(_context);
            try
            {
                updateBookCommand.Model=updatedBook;
                updateBookCommand.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
            /*var book = _context.Books.SingleOrDefault(x=>x.Id==id);
            if(book is null)
            {
                return BadRequest();

            }
            book.GenreId=updatedBook.GenreId!=default ? updatedBook.GenreId : book.GenreId;
            book.PageCount=updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate=updatedBook.PublishDate != default ? updatedBook.PublishDate: book.PublishDate;
            book.Title=updatedBook.Title!= default ? updatedBook.Title : book.Title;
            _context.SaveChanges();
            return Ok();*/
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.SingleOrDefault(x=>x.Id == id );
            if(book is null)
            { return BadRequest();}
            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}