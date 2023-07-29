namespace HolidayInACity.Infrastructure.Extensions;

public static class ServicesCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HolidayInACityDbContext>(options => options.UseSqlServer(
            configuration.GetConnectionString("HolidayInACityConnectionString")));
    }
}
