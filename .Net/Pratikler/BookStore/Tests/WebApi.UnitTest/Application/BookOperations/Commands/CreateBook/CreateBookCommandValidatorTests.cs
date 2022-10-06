using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.CreateBook;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.BookOperation.Commands.CreateBook
{
    public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture> {
        [Theory]
        [InlineData("Lord of the Rings",0,0)]
        [InlineData("", 0,1)]
        [InlineData("", 0, 0)]
        [InlineData("sss", 110, 0)]
        [InlineData("Lord of the Rings", 110, 0)]
        [InlineData("Lord", 1, 0)]

        public void WhenInvalidInputsAreGiven_Validator_SouldBeReturnErrors(string title,int PageCount,int GenreId){
            CreateBookCommand command = new CreateBookCommand(null,null);
            command.Model= new CreateBookModel(){
                Title=title,PageCount=PageCount,PublishDate=DateTime.Now.Date.AddYears(-1),GenreId=GenreId
            };
            CreateBookCommandValidator validator= new CreateBookCommandValidator();
            var result=validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDatetimeEqualNowIsGiven_Validator_ShouldBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord Of The Rings",
                PageCount = 1111,
                PublishDate = DateTime.Now.Date,
                GenreId = 1
            };
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenInvalidInputsAreGiven_Validator_SouldNotBeReturnError()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord Of The Rings",
                PageCount = 1111,
                PublishDate = DateTime.Now.Date.AddYears(-2),
                GenreId = 0
            };
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
    }
}
