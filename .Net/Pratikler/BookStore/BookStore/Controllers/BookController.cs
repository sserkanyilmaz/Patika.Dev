using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Web.BookOperations.GetById;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.DeleteBook;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.GetById;
using WebApi.BookOperations.UpdateBook;
using WebApi.DbOperations;

namespace WebApi.AddControllers{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase{
        private readonly BookStoreDbContext _context;
        private readonly IMapper  _mapper;
        public BookController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context,_mapper);
            var result = query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookDetailModel result;
            try
            {
                GetByIdCommand query = new GetByIdCommand(_context,_mapper);
                GetByIdCommandValidator validator = new GetByIdCommandValidator();
                query.BookId=id;
                validator.ValidateAndThrow(query);
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
            CreateBookCommand command = new CreateBookCommand(_context,_mapper);
            try
            {
                command.Model = newBook;

                CreateBookCommandValidator validator = new CreateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
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
                updateBookCommand.BookId=id;
                UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
                validator.ValidateAndThrow(updateBookCommand); 
                updateBookCommand.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
        DeleteBookCommand command = new DeleteBookCommand(_context);
        try
        {
            command.BookId=id;

            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
        }
        catch (Exception ex)
        {
            
            return BadRequest(ex.Message);
        }
            return Ok(); 
        }
    }
}