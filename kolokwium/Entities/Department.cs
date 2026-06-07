using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Entities;

[Table("Departments")]
public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    
    [MaxLength(100)] 
    public string Name { get; set; }
    
    [MaxLength(100)] 
    public string FacultyBuilding { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double Budget { get; set; }
    
    public List<Professor> Professors { get; set; } = new();
    
}