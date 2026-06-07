using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium.Entities;

[Table("Professors")]

public class Professor
{
    [Key]
    public int ProfessorId { get; set; }
    
    [MaxLength(100)] 
    public string FirstName { get; set; }
    
    [MaxLength(100)] 
    public string LastName { get; set; }
    
    [MaxLength(100)] 
    public string Email { get; set; }
    
    [ForeignKey(nameof(Department))]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    
    public List<Course> Courses { get; set; } = new();
}