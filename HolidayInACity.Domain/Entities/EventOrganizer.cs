namespace HolidayInACity.Domain.Entities;

public class EventOrganizer : EntityBase
{
    public string Name { get; set; } = default!;

    public ICollection<HolidayEvent> HolidayEvents { get; } = new List<HolidayEvent>();
    public EventOrganizerAddress EventOrganizerAddresses { get; set; } = default!;
    public EventOrganizerContact EventOrganizerContacts { get; set; } = default!;
}
