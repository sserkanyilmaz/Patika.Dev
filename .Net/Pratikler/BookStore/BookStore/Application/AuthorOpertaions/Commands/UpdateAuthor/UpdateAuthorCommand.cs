using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperation.Commands.UpdateAuthor{
    public class UpdateAuthorCommand{
        private readonly IBookStoreDbContext _context;
        public UpdateAuthorModel Model { get; set; }
        public int AuthorId { get; set; }
        public UpdateAuthorCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle(){
            var author = _context.Authors.SingleOrDefault(x=>x.AuthorId==AuthorId);
            if(author is null)
            {
                throw new InvalidOperationException("Yazar bulunamadı");
            }
            
            author.Name=Model.Name!=default?Model.Name:author.Surname;
            author.Surname=Model.Surname!=default?Model.Surname:Model.Surname;
            _context.SaveChanges();
        }
    }
    public class UpdateAuthorModel{
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}