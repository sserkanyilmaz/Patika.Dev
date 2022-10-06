using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.CreateBook;
using WebApi.Application.Commands.BookOperations.DeleteBook;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.BookOperation.Commands.DeleteBook
{
    public class DeleteBookCommandTests : IClassFixture<CommonTestFixture> {
        private readonly BookStoreDbContext _context;
        public DeleteBookCommandTests(CommonTestFixture commonTest)
        {
            _context=commonTest.Context;
        }
        [Theory]
        [InlineData(245)]
        [InlineData(234567)]
        public void WhenDeleteBookIsNotFound_InvalidOperationException_ReturnError(int id)
        {
           DeleteBookCommand command = new DeleteBookCommand(_context);
           command.BookId=id;
           FluentActions.Invoking(()=>command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap Bulunamadi"); 
        }
    }
}
