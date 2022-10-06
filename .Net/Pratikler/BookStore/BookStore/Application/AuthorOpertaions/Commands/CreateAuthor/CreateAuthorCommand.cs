using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperation.Commands.CreateAuthor{
    public class CreateAuthorCommand{
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateAuthorModel Model {get; set;}
        public CreateAuthorCommand(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle(){
            var author = _context.Authors.FirstOrDefault(x=>x.Name==Model.Name&&x.Surname==Model.Surname);
            if(author is not null)
            {
                throw new InvalidOperationException("Aynı isim ve soyisime sahip yazar bulunmaktadır");
            }            
            author = _mapper.Map<Author>(Model);
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

    }
    public class CreateAuthorModel{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
//veri yarat command çagır kurallarını yaz