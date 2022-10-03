using FluentValidation;

namespace WebApi.Application.GenreOperation.Queries.GetGenreDetail
{
    public class GetGenreQueryDetailValidator : AbstractValidator<GetGenreDetailQuery>{
        public GetGenreQueryDetailValidator()
        {
            RuleFor(x=>x.GenreId).GreaterThan(0);
        }
    }
}