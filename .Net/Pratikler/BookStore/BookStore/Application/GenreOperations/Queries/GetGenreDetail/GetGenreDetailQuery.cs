using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using System;

namespace WebApi.Application.GenreOperation.Queries.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        public readonly IBookStoreDbContext _context;
        public readonly IMapper _mapper;
        public int GenreId { get; set; }
        public GetGenreDetailQuery(IMapper mapper, IBookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public GetGenreDetailModel Handle()
        {
            var genres = _context.Genres.SingleOrDefault(x => x.IsActive&&x.Id==GenreId);
            if(genres is null )
            {
                throw new InvalidOperationException("Kitap türü bulunamadı");
            }
            GetGenreDetailModel returnObj = _mapper.Map<GetGenreDetailModel>(genres);
            return returnObj;
        }
    }
    public class GetGenreDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}