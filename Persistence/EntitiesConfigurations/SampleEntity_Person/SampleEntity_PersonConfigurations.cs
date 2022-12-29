using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntitiesConfigurations.SampleEntity_Person;

public class SampleEntity_PersonConfigurations:IEntityTypeConfiguration<Domain.Entities.SampleEntity_Person>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.SampleEntity_Person> builder)
    {
        builder.Property(e => e.Id)
            .IsRequired()
            .HasMaxLength(5)
            .ValueGeneratedNever();

        
        builder.Property(e => e.FirstName)
            .HasMaxLength(100);

    }
}