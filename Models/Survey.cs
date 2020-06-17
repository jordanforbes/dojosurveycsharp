using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string Name {get;set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string FavLang {get;set;} 

        [MinLength(20, ErrorMessage="Comment must have at least 20 characters")]
        public string Comment {get;set;}
    }
}