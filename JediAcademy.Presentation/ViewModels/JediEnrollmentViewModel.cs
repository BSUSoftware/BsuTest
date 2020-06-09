using System.Collections.Generic;
using JediAcademy.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JediAcademy.Presentation.ViewModels
{
    public class JediEnrollmentViewModel
    {
        public JediEnrollmentViewModel()
        {
            Species = new List<SelectListItem>{new SelectListItem("Select...",null)};
        }
        public List<SelectListItem> Species { get; set; }
        public string SelectedSpecies { get; set; }
    }
}