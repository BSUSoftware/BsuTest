using System.Collections.Generic;
using JediAcademy.Domain.Entities;

namespace JediAcademy.Presentation.ViewModels
{
    public class ExistingStudentsViewModel
    {
        public IEnumerable<JediStudent> JediStudents { get; set; }
    }
}