using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.DeleteBook;

namespace Application.BookOperation.Commands.DeleteBook
 {
    public class DeleteBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-552)]
        public void WhenInvalidInputsAreGiven_Validator_ReturnErrors(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(null);
            command.BookId = id;
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
    }
 }