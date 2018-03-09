using CottingsleyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottingsleyContracts
{
    public interface ILandingPageSurvey
    {
        void CreateEntry(Survey survey);
        Survey GetSurveyById(int id);
        List<object> GetSurveyQuestionList();
        void CreateQuestions(List<SurveyQuestion> surveyQuestions,List<SurveyQuestionOption> optionList);
    }
}
