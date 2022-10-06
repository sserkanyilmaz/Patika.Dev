using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Commands.DeleteAuthor;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.AuthorOperations.Commands.DeleteAuthor{
    public class DeleteAuthorCommandValidatorTests:IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public DeleteAuthorCommandValidatorTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(-4)]

        public void WhenAuthorIdIsNegativeOrZero_InvalidOperationException_ShouldReturn(int id)
        {
            var author = new Author
            {
                AuthorId = id
            };
            _context.Authors.Add(author);
            _context.SaveChanges();
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Geçersiz id girişi yapıldı");
        }
    }
}