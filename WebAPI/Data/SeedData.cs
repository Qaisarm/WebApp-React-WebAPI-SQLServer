using Microsoft.EntityFrameworkCore;
namespace WebAPI.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MyAppContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<MyAppContext>>()))
        {
            // Look for any movies.
            if (context.ActivityList.Any()) { return; }
            context.ActivityList.AddRange(
            new Models.ActivityModel
            {
                Title = "When Harry Met Sally",
                Category = "Food",
                DateOpened = DateTime.Parse("2022-2-12"),
                ExpiryDate = DateTime.Parse("2022-2-22")
            },
            new Models.ActivityModel
            {
                Title = "Name Two",
                Category = "Medicine",
                DateOpened = DateTime.Parse("2022-2-12"),
                ExpiryDate = DateTime.Parse("2023-2-12")
            }
            // and more
            );
            context.SaveChanges();
        }
    }
}