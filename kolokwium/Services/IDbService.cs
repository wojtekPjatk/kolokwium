using kolokwium.Data;
using kolokwium.DTO;

namespace kolokwium.Services;

public interface IDbService
{
    Task<List<ProfessorDto>> GetProfessor(string lastName);
}