namespace HolidayInACity.Domain.Entities.Configurations;

public class EventOrganizerConfiguration : IEntityTypeConfiguration<EventOrganizer>
{
    public void Configure(EntityTypeBuilder<EventOrganizer> builder)
    {
        builder.Property(x => x.Name)
               .IsRequired()
               .HasMaxLength(100);

        builder.HasMany(x => x.HolidayEvents)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey(z => z.EventOrganizerId)
               .IsRequired();

        builder.HasOne(x => x.EventOrganizerAddresses)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey<EventOrganizerAddress>(z => z.EventOrganizerId)
               .IsRequired();

        builder.HasOne(x => x.EventOrganizerContacts)
               .WithOne(y => y.EventOrganizer)
               .HasForeignKey<EventOrganizerContact>(z => z.EventOrganizerId)
               .IsRequired();
    }
}
