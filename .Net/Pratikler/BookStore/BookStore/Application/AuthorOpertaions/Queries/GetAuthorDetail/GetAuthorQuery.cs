using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Queries.GetAuthorDetail
{
    public class GetAuthorQuery{
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuthotDetailModel Handle()
        {
            var author = _context.Authors.SingleOrDefault(x=>x.AuthorId==AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadi");
            }
            AuthotDetailModel returnobj = _mapper.Map<AuthotDetailModel>(author);
            return returnobj;
        }
    }
    public class AuthotDetailModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }
}