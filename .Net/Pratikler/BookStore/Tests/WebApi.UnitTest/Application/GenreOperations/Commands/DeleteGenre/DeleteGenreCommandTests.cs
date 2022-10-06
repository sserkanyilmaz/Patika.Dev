using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperation.Command.DeleteGenre;
using WebApi.DbOperations;

namespace Application.GenreOperations.Commands.DeleteGenre{
    public class DeleteGenreCommandTests:IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public DeleteGenreCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Theory]
        [InlineData(6)]
        [InlineData(234567)]
        [InlineData(5)]
        public void WhenWillBeDeletedGenreIsNotFound(int id)
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId=id;
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap türü bulunamadı");
        }
    }
}