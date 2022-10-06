using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperation.Command.CreateGenre;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("aa")]
        [InlineData("aaa")]
        public void WhenInvalidInputsAreGiven_InvalidOperationException_ReturnErrors(string name)
        {
            CreateGenreCommand command = new CreateGenreCommand(null);
            command.Model= new CreateGenreModel{
                Name=name
            };
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
    }
}
