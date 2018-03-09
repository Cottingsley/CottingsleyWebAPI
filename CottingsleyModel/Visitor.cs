using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottingsleyModel
{
    public class Visitor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }

        public int SchoolId { get; set; }

        public int SurveyId { get; set; }

        [ForeignKey("SurveyId")]
        public Survey SurveyObj { get; set; }
        [ForeignKey("SchoolId")]
        public School SchoolObj { get; set; }
    }
}
