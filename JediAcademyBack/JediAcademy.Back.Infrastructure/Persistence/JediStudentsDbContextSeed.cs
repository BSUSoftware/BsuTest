using JediAcademy.Back.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JediAcademy.Back.Infrastructure.Persistence
{
    public static class JediStudentsDbContextSeed
    {
        public static async Task SeedDataAsync(JediStudentsDbContext dbContext)
        {
            // Seed, if necessary
            if (!dbContext.JediStudents.Any())
            {
                var data = await System.IO.File.ReadAllTextAsync("SeedData/Individuals.json");
                if (!string.IsNullOrEmpty(data))
                {
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                    var students = JsonSerializer.Deserialize<IEnumerable<JediStudent>>(data, options);
                    if (students != null)
                        foreach (var student in students)
                        {
                            dbContext.Add(new JediStudent
                            {
                                Id = Guid.NewGuid().GetHashCode(),
                                Height = student.Height,
                                Mass = student.Mass,
                                Name = student.Name,
                                Species = student.Species
                            });
                            await dbContext.SaveChangesAsync();
                        }
                }
            }
        }
    }
}
