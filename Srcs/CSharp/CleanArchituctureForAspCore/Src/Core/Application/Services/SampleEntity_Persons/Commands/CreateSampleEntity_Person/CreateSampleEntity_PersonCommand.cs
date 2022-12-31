using Application.Common.Models;
using Application.Interfaces;
using Common.Enums;
using Domain.Entities;
using MediatR;
using EasyMicroservices.Utilities.Text;
namespace Application.Services.SampleEntity_Persons.Commands.CreateSampleEntity_Person;

public class CreateSampleEntity_PersonCommand:IRequest<BaseResult<SampleEntity_Person>>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public string Password { get; set; }
    public class Handler : IRequestHandler<CreateSampleEntity_PersonCommand, BaseResult<SampleEntity_Person>>
    {
        private readonly IDataBaseContext _context;

        public Handler(IDataBaseContext context)
        {
            _context = context;
        }

        public async Task<BaseResult<SampleEntity_Person>> Handle(CreateSampleEntity_PersonCommand request, CancellationToken cancellationToken)
        {
            var entity = new SampleEntity_Person()
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender ,
                Password = HashHelper.GetSHA1Hash(request.Password)
            };
            try
            {
                _context.SampleEntity_Persons.Add(entity);
                await _context.SaveChangesAsync(cancellationToken);

                return new BaseResult<SampleEntity_Person>(true, new []{""}, entity);
            }
            catch (Exception e)
            {
                return new BaseResult<SampleEntity_Person>(false, new[] { e.Message }, entity);
            }
        }
    }

}