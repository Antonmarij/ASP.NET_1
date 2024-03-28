using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CourseEntity
{
    [Key]
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public bool IsBestseller { get; set; }

    public bool IsDigital { get; set; }

    public string Author { get; set; } = null!;

    public decimal OriginalPrice { get; set; }

    public decimal DiscountPrice { get; set; }

    public int Hours { get; set; }

    public decimal LikesInProcent { get; set; }

    public decimal LikesInNumbers { get; set; }

    public string? CourseImageUrl { get; set; }

}
