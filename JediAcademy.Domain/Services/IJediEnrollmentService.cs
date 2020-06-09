using System.Collections.Generic;
using System.Threading.Tasks;
using JediAcademy.Domain.Entities;

namespace JediAcademy.Domain.Services
{
    public interface IJediEnrollmentService
    {
        Task<(bool IsSuccess, IEnumerable<Species> Result)> GetAvailableSpecies();
        Task<(bool IsSuccess, IEnumerable<JediStudent> Result)> GetExistingStudents();
    }
}