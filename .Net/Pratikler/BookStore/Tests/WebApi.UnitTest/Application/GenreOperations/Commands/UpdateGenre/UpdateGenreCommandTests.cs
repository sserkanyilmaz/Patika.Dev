using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperation.Command.UpdateGenre;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommandTests:IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        public UpdateGenreCommandTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
        }
        [Theory]
        [InlineData(1234)]
        [InlineData(3254678)]
        [InlineData(79065)]
        public void WhenInvalidInputsAreGiven_InvalidOperationException_ReturnErrors(int id)
        {
            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = id;
            command.Model = new UpdateGenreModel();
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap türü bulunamadı");
        }
        [Fact]
        public void  WhenNewGenreNameEqualsAnotherGenreName_InvalidOperationException()
        {   UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = 1;
            command.Model = new UpdateGenreModel{
                Name = "Science Fiction"
            };
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Aynı isimde kitap türü mevcut");


        }
    }
}
