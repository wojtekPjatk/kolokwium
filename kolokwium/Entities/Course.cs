using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kolokwium.Entities;

[Table("Courses")]
public class Course
{
    [Key]
    public int CourseId { get; set; }
    
    [MaxLength(100)] 
    public string Title { get; set; }
    public int Credits { get; set; }
    public int Semester { get; set; }
    
    [ForeignKey(nameof(Professor))]
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
}