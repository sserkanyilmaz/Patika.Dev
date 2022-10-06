using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Queries.GetAuthorDetail;
using WebApi.DbOperations;

namespace Application.AuthorOperations.Queries.GetAuthorDetail{
    public class GetAuthorDetailCommand : IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorDetailCommand(CommonTestFixture testFixture)
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
        public void WhenAuthorIdIsNotFound_InvalidOperationException_ShouldReturnError(int id)
        {
            var authorId = id;
            GetAuthorQuery command = new GetAuthorQuery(_context,_mapper);
            command.AuthorId = authorId;
            FluentActions.Invoking(() => command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yazar bulunamadı");

        }
    }
}