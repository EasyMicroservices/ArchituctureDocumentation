using FluentValidation;

namespace Application.Services.SampleEntity_Persons.Commands.CreateSampleEntity_Person;

public class CreateSampleEntity_PersonCommandValidator:AbstractValidator<CreateSampleEntity_PersonCommand>
{
    public CreateSampleEntity_PersonCommandValidator()
    {
        RuleFor(e => e.FirstName)
            .NotEmpty().NotNull().WithMessage("Please Enter FirstName!")
            .MaximumLength(100).WithMessage("FirstName must not exceed 100 characters.");
        
        RuleFor(e => e.LastName)
            .NotEmpty().NotNull().WithMessage("Please Enter LastName!")
            .MaximumLength(100).WithMessage("LastName must not exceed 100 characters.");
        
        RuleFor(e => e.Gender)
            .NotEmpty().NotNull().WithMessage("Please Select Gender!")
            .IsInEnum();

    }
}