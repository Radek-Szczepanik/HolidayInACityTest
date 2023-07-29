namespace HolidayInACity.Domain.Entities;

public class EventOrganizerContact : EntityBase
{
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;

    public int EventOrganizerId { get; set; }
    public EventOrganizer EventOrganizer { get; set; } = default!;
}
