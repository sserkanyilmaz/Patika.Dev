using System;
using System.Linq;
using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperation.Command.UpdateGenre{
    public class UpdateGenreCommand{
        public int GenreId { get; set; }
        private readonly IBookStoreDbContext _context;
        public UpdateGenreModel Model {get; set;}
        public UpdateGenreCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x=>x.Id ==GenreId);
            if(genre is null)
            {
                throw new InvalidOperationException("Kitap türü bulunamadı");
            }
            if (_context.Genres.Any(x=>x.Name.ToLower()==Model.Name.ToLower() && x.Id != GenreId))
            {
                throw new InvalidOperationException("Aynı isimde kitap türü mevcut");
            }
            genre.Name=string.IsNullOrEmpty(Model.Name.Trim()) ?genre.Name:Model.Name;
            genre.IsActive=Model.IsActive;
            _context.SaveChanges();

        }
    }
    public class UpdateGenreModel{
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}