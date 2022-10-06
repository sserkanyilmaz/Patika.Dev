using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.AuthorOperation.Commands.DeleteAuthor;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandTests : IClassFixture<CommonTestFixture> {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public DeleteAuthorCommandTests(CommonTestFixture testFixture)
        {
            _context=testFixture.Context;
            _mapper=testFixture.Mapper;
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void WhenAuthorAlreadyHasABook_InvalidOperationException_ShouldReturnError(int id){
            var authorsBook = _context.Books.Where(x => x.AuthorId == id).Any();
            
            
        }
        
    }
}