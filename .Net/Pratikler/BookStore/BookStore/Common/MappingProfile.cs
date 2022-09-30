using AutoMapper;
using Web.BookOperations.GetById;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBooks;

namespace WebApi.Common
{
    public class MappingProfile: Profile{
        public MappingProfile()
        {
            CreateMap<CreateBookModel , Book>();
            CreateMap<Book,BookDetailModel>().ForMember(dest=>dest.Genre, opt=>opt.MapFrom(src=>((GenreEnum)src.GenreId).ToString()));
            CreateMap<Book,BooksViewModel>().ForMember(dest=>dest.Genre,opt=>opt.MapFrom(src=>((GenreEnum)src.GenreId).ToString()));
        }
    }
}  