using FluentValidation;

namespace WebApi.Application.AuthorOperation.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidator :AbstractValidator<UpdateAuthorCommand>{
        public UpdateAuthorCommandValidator()
        {
            RuleFor(command=>command.Model.Name).MinimumLength(3).NotEmpty();
            RuleFor(command=>command.Model.Surname).MinimumLength(3).NotEmpty();   
        }
    }
}