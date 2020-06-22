using JediAcademy.Back.Application.Interfaces;
using JediAcademy.Back.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace JediAcademy.Back.Infrastructure.Persistence
{
    public class JediStudentsDbContext : DbContext, IJediStudentsDbContext
    {
        public DbSet<JediStudent> JediStudents { get; set; }

        public JediStudentsDbContext(DbContextOptions options) : base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}