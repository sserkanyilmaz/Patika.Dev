using AutoMapper;
using WebApi.Entities;
using WebApi.Application.Commands.BookOperations.CreateBook;
using Web.Application.Queries.BookOperations.GetById;
using WebApi.Application.Queries.BookOperations.GetBooks;
using WebApi.Application.GenreOperation.Queries.GetGenreDetail;
using WebApi.Application.GenreOperation.Queries.GetGenres;
using WebApi.Application.AuthorOperation.Queries.GetAuthorDetail;
using WebApi.Application.AuthorOperation.Queries.GetAuthors;
using WebApi.Application.AuthorOperation.Commands.CreateAuthor;

namespace WebApi.Common
{
    public class MappingProfile: Profile{
        public MappingProfile()
        {
            CreateMap<CreateBookModel , Book>();
            CreateMap<Book,BookDetailModel>().ForMember(dest=>dest.Genre, opt=>opt.MapFrom(src=>src.Genre.Name));
            CreateMap<Book,BooksViewModel>().ForMember(dest=>dest.Genre,opt=>opt.MapFrom(src => src.Genre.Name));
            CreateMap<Genre,GetGenresViewModel>();
            CreateMap<Genre,GetGenreDetailModel>();
            CreateMap<CreateAuthorModel, Author>();
            CreateMap<Author,AuthorDetailModel>();
            CreateMap<Author,GetAuthorModel>();
        }
    }
}  