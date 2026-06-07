using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Entities;

[Table("Enrollments")]
[PrimaryKey(nameof(CourseId), nameof(StudentId))]
public class Enrollment
{
    [ForeignKey(nameof(Course))]
    public int CourseId { get; set; }
    public Course Course { get; set; }
    
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }
    public Student Student { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(2, 1)]
    public double? Grade { get; set; }
    
    [MaxLength(100)] 
    public string Status { get; set; }
}