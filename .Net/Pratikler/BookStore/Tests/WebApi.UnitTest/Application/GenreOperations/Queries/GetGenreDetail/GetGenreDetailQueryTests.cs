using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Queries.GetAuthorDetail;
using WebApi.Application.GenreOperation.Queries.GetGenreDetail;
using WebApi.DbOperations;

namespace Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetGenreDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetGenreDetailQueryTests(CommonTestFixture testFixture)
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        [Theory]
        [InlineData(67)]
        [InlineData(68)]
        [InlineData(45)]
        [InlineData(78)]
        [InlineData(987654)]
        [InlineData(890)]
        public void WhenGenresIdIsNotFound_InvalidOperationException_ShouldReturnError(int id)
        {
            var authorId = id;
            GetGenreDetailQuery command = new GetGenreDetailQuery(_mapper,_context);
            command.GenreId = id;
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap türü bulunamadı");

        }
    }
}