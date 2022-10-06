using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.DeleteBook;
using WebApi.Application.Commands.BookOperations.UpdateBook;
using WebApi.DbOperations;

namespace Application.BookOperation.Commands.UpdateBook
{
    public class UpdateBookCommandTests:IClassFixture<CommonTestFixture>{
        private  readonly BookStoreDbContext _context;
        public UpdateBookCommandTests(CommonTestFixture testFixture)
        {
            _context=testFixture.Context;            
        }
        [Theory] 
        [InlineData(1234)]
        [InlineData(3254678)]
        [InlineData(79065)]
        public void WhenInvalidInputsAreGiven_InvalidOperationException_ReturnErrors(int id)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            command.BookId=id;
            command.Model= new UpdateBookModel();
            FluentActions.Invoking(()=>command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap Bulunamadi");
        }
    }
}