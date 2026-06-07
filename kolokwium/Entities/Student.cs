using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium.Entities;

[Table("Students")]
public class Student
{
    [Key]
    public int StudentId { get; set; }
    
    [Required]
    [MaxLength(100)] 
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)] 
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(100)] 
    public string Email { get; set; }
    
    public int EnrollmentYear { get; set; }
    
    public List<Enrollment> Enrollments { get; set; } = new();

}