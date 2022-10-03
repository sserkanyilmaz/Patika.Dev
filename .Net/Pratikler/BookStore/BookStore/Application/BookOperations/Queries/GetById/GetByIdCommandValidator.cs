using FluentValidation;
using Web.Application.Queries.BookOperations.GetById;

namespace WebApi.Application.Queries.BookOperations.GetById{
    public class GetByIdCommandValidator : AbstractValidator<GetByIdCommand>{
        public GetByIdCommandValidator()
        {
            RuleFor(command=>command.BookId).GreaterThan(0);
        }
    }
}