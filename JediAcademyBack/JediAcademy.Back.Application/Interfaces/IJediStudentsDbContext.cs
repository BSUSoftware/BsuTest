using JediAcademy.Back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace JediAcademy.Back.Application.Interfaces
{
    public interface IJediStudentsDbContext
    {
        DbSet<JediStudent> JediStudents { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}