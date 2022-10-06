using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.UpdateBook;

namespace Application.BookOperation.Commands.UpdateBook
{
    public class UpdateBookCommandValidatorTests : IClassFixture<CommonTestFixture>{
        [Theory]
        [InlineData("",0,0)]
        [InlineData("",1,0)]
        [InlineData("aaaa", 0, 0)]
        [InlineData("aaaa",0,1)]
        [InlineData("",1,1)]
        [InlineData("aaaa",1,0)]
        public void WhenInvalidInputsAreGiven_InvalidOperationException_ReturnErrors(string title,int genreId, int id)
        {
            UpdateBookCommand command = new UpdateBookCommand(null);
            command.BookId=id;
            command.Model= new UpdateBookModel{
                Title=title,
                GenreId=genreId
            };
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
    }
}