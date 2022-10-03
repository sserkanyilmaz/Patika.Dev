using FluentValidation;

namespace WebApi.Application.GenreOperation.Command.CreateGenre
{
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>{
        public CreateGenreCommandValidator()
        {
            RuleFor(command=>command.Model.Name).MinimumLength(4).NotEmpty();
        }
    }
}
   