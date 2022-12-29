using System.Reflection;
using Application.Services.SampleEntity_Person.Commands.CreateSampleEntity_Person;
using Application.Services.SampleEntity_Person.Commands.DeleteSampleEntity_Person;
using Application.Services.SampleEntity_Person.Commands.UpdateSampleEntity_Person;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Common.IOCConfigurations;

public static class RegisterValidations
{
    public static IServiceCollection AddValidations(this IServiceCollection service, Assembly assembly)
    {
        service.AddFluentValidationAutoValidation();
    
        service.AddScoped<IValidator<CreateSampleEntity_PersonCommand> ,CreateSampleEntity_PersonCommandValidator>();
        service.AddScoped<IValidator<DeleteSampleEntity_PersonCommand> ,DeleteSampleEntity_PersonCommandValidator>();
        service.AddScoped<IValidator<UpdateSampleEntity_PersonCommand> ,UpdateSampleEntity_PersonCommandValidator>();
        
        return service;
    }
}