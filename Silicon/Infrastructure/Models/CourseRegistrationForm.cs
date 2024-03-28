namespace Infrastructure.Models;

public class CourseRegistrationForm
{

    public string Title { get; set; } = null!;

    public bool IsDigital { get; set; }

    public string Author { get; set; } = null!;

    public decimal OriginalPrice { get; set; }

    public int Hours { get; set; }

    public string? CourseImageUrl { get; set; }


}
