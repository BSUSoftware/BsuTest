using JediAcademy.Presentation.ViewModels;
using System.Collections.Generic;

namespace JediAcademy.Presentation.Services
{
    public interface IJediEnrollmentService
    {
        System.Threading.Tasks.Task<(bool IsSuccess, IEnumerable<Species> Result)> GetAvailableSpecies();
        System.Threading.Tasks.Task<(bool IsSuccess, IEnumerable<JediStudent> Result)> GetExistingStudents();
    }
}