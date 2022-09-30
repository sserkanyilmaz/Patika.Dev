using FluentValidation;
using Web.BookOperations.GetById;

namespace WebApi.BookOperations.GetById{
    public class GetByIdCommandValidator : AbstractValidator<GetByIdCommand>{
        public GetByIdCommandValidator()
        {
            RuleFor(command=>command.BookId).GreaterThan(0);
        }
    }
}