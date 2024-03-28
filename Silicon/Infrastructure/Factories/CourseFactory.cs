using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseEntity Create(CourseRegistrationForm form)
    {
        try
        {
            return new CourseEntity
            {
                Id = Guid.NewGuid().ToString(),
                Title = form.Title,
                OriginalPrice = form.OriginalPrice,
                IsDigital = form.IsDigital,
                Author = form.Author,
                Hours = form.Hours,
                CourseImageUrl = form.CourseImageUrl
            };
        }
        catch { }
        return null!;
    }
}
