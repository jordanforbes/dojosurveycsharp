using System.Collections.Generic;

namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name {get;set;}
        public List<string> Location {get;set;}
        public List<string> FavLang {get;set;} 
        public string Comment {get;set;}
    }
}