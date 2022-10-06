using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperation.Queries.GetGenres
{
    public class GetGenresQuery{
        public readonly IBookStoreDbContext _context ;
        public readonly IMapper _mapper;
        public GetGenresQuery(IMapper mapper, IBookStoreDbContext context = null)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetGenresViewModel> Handle()
        {
            var genres = _context.Genres.Where(x=>x.IsActive).OrderBy(x=>x.Id);
            List<GetGenresViewModel> returnObj = _mapper.Map<List<GetGenresViewModel>>(genres);
            return returnObj;
        }   
    }
    public class GetGenresViewModel{
        public int  Id { get; set; }
        public string Name { get; set; }
    }
}