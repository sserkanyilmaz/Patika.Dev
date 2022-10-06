using WebApi.DbOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Gneres
    {
        public static void AddGenre( this BookStoreDbContext context){
            context.Genres.AddRange(
                new Genre{Name = "Personal Growth" },
                new Genre{Name = "Science Fiction"},
                new Genre{ Name = "Romance" });
        }
    }

}
