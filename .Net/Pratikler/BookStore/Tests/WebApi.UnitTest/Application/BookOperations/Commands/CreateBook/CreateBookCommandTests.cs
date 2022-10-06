using AutoMapper;
using FluentAssertions;
using TestSetup;
using WebApi.Application.Commands.BookOperations.CreateBook;
using WebApi.DbOperations;
using WebApi.Entities;

namespace Application.BookOperation.Commands.CreateBook
{
    public class CreateBookCommandTests: IClassFixture<CommonTestFixture>{
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateBookCommandTests(CommonTestFixture testFixture)
        {
            _context=testFixture.Context;
            _mapper=testFixture.Mapper;
        }
        [Fact]
        public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldReturn()
        {
            //arrange hazırlık
            var book = new Book(){Title="WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldReturn", PageCount =100,PublishDate=new DateTime(1990,10,12),GenreId=1};
            _context.Books.Add(book);
            _context.SaveChanges();

            CreateBookCommand command = new CreateBookCommand(_context,_mapper) ;
            command.Model= new CreateBookModel{Title=book.Title};

            //act çalıştırma && assert doğrulama
            FluentActions.Invoking(()=>command.Handle()).Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut");
            //
        }
        [Fact]
        public void WhenValidInputAreGıven_Book_ShouldCreated()
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            CreateBookModel model = new CreateBookModel(){Title="hobbit",PageCount=400,GenreId=1,PublishDate=DateTime.Now.Date.AddYears(-10)};
            command.Model= model;
            FluentActions.Invoking(() => command.Handle()).Invoke();

            var book = _context.Books.SingleOrDefault(book=>book.Title==model.Title);
            book.Should().NotBeNull();
            book.PageCount.Should().Be(model.PageCount);
            book.PublishDate.Should().Be(model.PublishDate);
            book.Title.Should().Be(model.Title);
            book.GenreId.Should().Be(model.GenreId);
        }

    }
}