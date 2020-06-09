using JediAcademy.Back.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jedi.Academy.Persistence.Db
{
    public class JediStudentsDbContext : DbContext
    {
        public DbSet<JediStudent> JediStudents { get; set; }

        public JediStudentsDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}