using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_review_2022.Model;

public class School
{
    public int SchoolId { get; set; }
    [MaxLength(30, ErrorMessage = "School's name can be at most 30 characters because I said so!")]
    public string? Name { get; set; }

    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [NotMapped, DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string? VerifyPassword { get; set; }
    [Range(1, 5, ErrorMessage = "1-5 only!")]
    public int Rating { get; set; }
    public virtual ICollection<Class>? AvailableClasses { get; set; }
    public int? StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? PostalCode { get; set; }
    [Required]
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Phone { get; set; }

}