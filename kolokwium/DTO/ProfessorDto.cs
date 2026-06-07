namespace kolokwium.DTO;

public class ProfessorDto
{
    
    public int ProfessorId { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public List<CourseDto> CourseDto { get; set; } = null!;
}

public class CourseDto
{
    public int CourseId { get; set; }
    
    public string Title { get; set; }
    public int Credits { get; set; }
    public int Semester { get; set; }
    public List<EnrollmentDto> EnrollmentDto { get; set; } = null!;
}

public class EnrollmentDto
{
    public double? Grade { get; set; }
    public string Status { get; set; }
    public StudentDto Student { get; set; } = null!;
}

public class StudentDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int EnrollmentYear { get; set; }
}