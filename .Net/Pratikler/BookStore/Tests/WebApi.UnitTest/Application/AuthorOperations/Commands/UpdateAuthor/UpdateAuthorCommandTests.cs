using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Commands.UpdateAuthor;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.AuthorOperations.Commands.UpdateAuthor{
    public class UpdateAuthorCommandTests:IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public UpdateAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context=testFixture.Context;
            _mapper=testFixture.Mapper;
        }
        [Theory]
        [InlineData(67)]
        [InlineData(68)]
        [InlineData(45)]
        [InlineData(78)]
        [InlineData(987654)]
        [InlineData(890)]
        public void WhenAuthorIdIsNotFound_InvalidOperationException_ShouldReturnError(int id){
            var authorId=id;
            var model = new UpdateAuthorModel{
                Name="Serkan",
                Surname="Yilmaz"
            };
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId=authorId;
            command.Model=model;
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yazar bulunamadı");
            
        }
    }
}