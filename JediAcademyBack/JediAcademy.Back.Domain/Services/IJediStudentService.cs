using System.Collections.Generic;
using System.Threading.Tasks;
using JediAcademy.Back.Domain.Entities;

namespace JediAcademy.Back.Domain.Services
{
    public interface IJediStudentsService
    {
        Task<(bool isSuccess, IEnumerable<JediStudent> JediStudents, string ErrorMessage)> GetJediStudents();
    }
}