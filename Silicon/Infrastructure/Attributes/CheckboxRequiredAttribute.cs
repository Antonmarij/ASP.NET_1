using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Attributes;

public class CheckboxRequiredAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        return value is bool b && b;
    }

}
