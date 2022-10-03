using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Genres.AddRange(new Genre{
                    Name="Personal Growth"
                },
                new Genre{
                    Name="Science Fiction"
                },
                new Genre
                {
                    Name = "Romance"
                });
                context.Books.AddRange(
                new Book
                {
                    Title = "Lean Startup",
                    GenreId = 1,
                    PageCount = 200,
                    AuthorId = 1,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new Book
                {
                    Title = "Herland",
                    GenreId = 2,
                    AuthorId=1,
                    PageCount = 250,
                    PublishDate = new DateTime(2010, 05, 23)
                },
                new Book
                {
                    Title = "Dune",
                    GenreId = 2,
                    PageCount = 540,
                    AuthorId = 2,
                    PublishDate = new DateTime(2001, 12, 21)
                });
                context.AddRange(new Author{
                    Name= "Frank",
                    Surname="Herbert",
                    Birthday=new DateTime(1930, 06, 12),
                },
                new Author{
                    Name= "Charlotte Perkins",
                    Surname="Gilman",
                    Birthday=new DateTime(1930, 06, 12),
                });
                context.SaveChanges();
            }
        }
    }
}