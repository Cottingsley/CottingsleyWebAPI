using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CottingsleyModel
{
    public class Survey
    {
        public int Id { get; set; }
        public DateTime GivenOn { get; set; }
        public virtual ICollection<SurveyQuestion> QuestionList { get; set; }
    }

    [DataContractAttribute]
    public class SurveyQuestion
    {
        [DataMemberAttribute]
        public int Id { get; set; }
        [DataMemberAttribute]
        public string Question { get; set; }
        public virtual ICollection<SurveyQuestionOption> Options { get; set; }

        //public int SurveyId { get; set; }

        //[ForeignKey("SurveyId")]
        //public Survey SurveyObj { get; set; }
       
    }
    [DataContractAttribute]
    public class SurveyQuestionOption {
        [DataMemberAttribute]
        public int Id { get; set; }
        [DataMemberAttribute]
        public int SurveyQuestionId { get; set; }

        [ForeignKey("SurveyQuestionId")]
        public virtual SurveyQuestion SurveyQuestionObj { get; set; }
        [DataMemberAttribute]
        public string Option { get; set; }
    }

    public class SurveyAnswer
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public int SurveyQuestionId { get; set; }

        //[ForeignKey("SurveyQuestionId")]
        //public virtual SurveyQuestion SurveyQuestionObj { get; set; }
    }
}
