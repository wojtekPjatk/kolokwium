using kolokwium.Data;
using kolokwium.DTO;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.Services;

public class DbService
{
    private readonly AppDbContext _context;
    
    public DbService(AppDbContext context)
    {
        _context = context;
    }

    // public async Task<List<ProfessorDto>> GetProfessor(string lastName)
    // {
    //     var professors = await _context.Professors.Include(p => p.Courses)
    // }
}