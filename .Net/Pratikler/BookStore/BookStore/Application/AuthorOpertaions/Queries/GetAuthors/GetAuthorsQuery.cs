using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Queries.GetAuthors
{
    public class GetAuthorsQuery{
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorsQuery(IMapper mapper, IBookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public List<GetAuthorModel> Handle(){
            var authors = _context.Authors.OrderBy(x=>x.AuthorId);
            List<GetAuthorModel> authorModelList = _mapper.Map<List<GetAuthorModel>>(authors);
            return authorModelList;
        }
    }
    public class GetAuthorModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}