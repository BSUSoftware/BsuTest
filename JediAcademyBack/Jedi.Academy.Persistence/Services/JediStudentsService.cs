using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Jedi.Academy.Persistence.Db;
using JediAcademy.Back.Domain.Entities;
using JediAcademy.Back.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace Jedi.Academy.Persistence.Services
{
    public class JediStudentsService : IJediStudentsService
    {
        private readonly JediStudentsDbContext _dbContext;

        public JediStudentsService(JediStudentsDbContext dbContext)
        {
            _dbContext = dbContext;
            SeedData();
        }

        public async Task<(bool isSuccess, IEnumerable<JediStudent> JediStudents, string ErrorMessage)> GetJediStudents()
        {
            try
            {
                var students = await _dbContext.JediStudents.ToListAsync();
                if (students != null && students.Any())
                {
                    return (true, students, null);
                }

                return (false, students, "No Jedi Students found");
            }
            catch (Exception exception)
            {
                return (false, null, exception.Message);
            }
        }

        private void SeedData()
        {
            if (!_dbContext.JediStudents.Any())
            {
                var data = System.IO.File.ReadAllText("SeedData/Individuals.json");
                if (!string.IsNullOrEmpty(data))
                {
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var students = JsonSerializer.Deserialize<IEnumerable<JediStudent>>(data, options);
                    foreach (var student in students)
                    {
                        _dbContext.Add(new JediStudent
                        {
                            Id = Guid.NewGuid().GetHashCode(),
                            Height = student.Height,
                            Mass = student.Mass,
                            Name = student.Name,
                            Species = student.Species
                        });
                        _dbContext.SaveChanges();
                    }
                }
            }
        }
    }
}