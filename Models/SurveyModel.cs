using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithValidationsNew.Models
{
	public class SurveyModel
	{
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Choose a location from the dropdown")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please choose a language from the dropdown")]
        public string Language { get; set; }

        [MaxLength(20, ErrorMessage = "Comments must be under 20 characters long")]
        public string? Comment { get; set; }
    }
}

