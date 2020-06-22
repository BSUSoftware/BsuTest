using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string SelectedSpecies { get; set; }
    }
}