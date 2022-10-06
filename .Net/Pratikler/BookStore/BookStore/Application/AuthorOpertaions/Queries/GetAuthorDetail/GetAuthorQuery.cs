using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Queries.GetAuthorDetail
{
    public class GetAuthorQuery{
        public int AuthorId { get; set; }
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuthorDetailModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.AuthorId==AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            AuthorDetailModel returnobj = _mapper.Map<AuthorDetailModel>(author);
            return returnobj;
        }
    }
    public class AuthorDetailModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }
}