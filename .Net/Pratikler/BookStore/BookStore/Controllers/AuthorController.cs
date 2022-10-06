using System.Collections.Generic;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.AuthorOperation.Commands.CreateAuthor;
using WebApi.Application.AuthorOperation.Commands.DeleteAuthor;
using WebApi.Application.AuthorOperation.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperation.Queries.GetAuthorDetail;
using WebApi.Application.AuthorOperation.Queries.GetAuthors;
using WebApi.DbOperations;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class AuthorController : ControllerBase{
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public AuthorController(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAuthors(){
            GetAuthorsQuery query = new GetAuthorsQuery(_mapper,_context);
            var obj = query.Handle();
            return Ok(obj); 
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetAuthorQuery query = new GetAuthorQuery(_context,_mapper);
            query.AuthorId=id;
            var obj = query.Handle();
            return Ok(obj);
        }
        [HttpPost]
        public IActionResult CreateAuthor([FromBody] CreateAuthorModel model)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(_context,_mapper);
            command.Model=model;
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpPut("{id}")]//
        public IActionResult UpdateAuthor(int id , [FromBody] UpdateAuthorModel model){
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.Model=model;
            command.AuthorId=id;
            UpdateAuthorCommandValidator validator = new UpdateAuthorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId=id;
            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
    }
}