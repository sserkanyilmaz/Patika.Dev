using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Commands.CreateAuthor;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.AuthorOperations.Commands.CreateAuthor{
    public class CreateAuthorCommandTests : IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Fact]
        public void WhenAlreadyExistAuthorNameIsGiven_InvalidOperationException_ShouldReturn()
        {
            var author = new Author(){
                Name = "Frank",
                Surname = "Herbert"
            };
            _context.Authors.Add(author);
            _context.SaveChanges();

            CreateAuthorCommand command = new CreateAuthorCommand(_context,_mapper);
            command.Model= new CreateAuthorModel{
                Name = author.Name,
                Surname = author.Surname
            };

            FluentActions.Invoking(()=>command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Aynı isim ve soyisime sahip yazar bulunmaktadır");

        }
    }
}