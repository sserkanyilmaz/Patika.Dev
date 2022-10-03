using FluentValidation;
using WebApi.Application.AuthorOperation.Commands.DeleteAuthor;

namespace WebApi.Application.AuthorOperation.Commands.CreateAuthor
{
    public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand> {
        public DeleteAuthorCommandValidator()
        {
            RuleFor(command => command.AuthorId).GreaterThan(0);
        }
    }
}
