using FluentValidation;
using Web.Application.Queries.BookOperations.GetById;

namespace WebApi.Application.Queries.BookOperations.GetById{
    public class GetByIdCommandValidator : AbstractValidator<GetByIdQuery>{
        public GetByIdCommandValidator()
        {
            RuleFor(command=>command.BookId).GreaterThan(0);
        }
    }
}