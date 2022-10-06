using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.GenreOperation.Command.CreateGenre;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.GenreOperations.Commands.CreateGenre{
    public class CreateGenreCommandTests:IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateGenreCommandTests(CommonTestFixture testFixture)
        {
            _context=testFixture.Context;
            _mapper=testFixture.Mapper;
        }
        [Fact]
        public void WhenAlreadyExistGenreNameIsGiven_InvalidOperationException_ReturnError()
        {
            var genre = new Genre{
                Name="psychology",
            };
            _context.Genres.Add(genre);
            _context.SaveChanges();
            CreateGenreCommand command = new CreateGenreCommand(_context);
            command.Model= new CreateGenreModel{
                Name=genre.Name
            };
            FluentActions.Invoking(()=>command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Bu tür zaten mevcut");
        }
    }
}