using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyService
{
    public class LandingPageSurvey : ILandingPageSurvey
    {
        ILandingPageSurvey surveyRepo;
        public LandingPageSurvey() {
            surveyRepo = new CottingsleyRepository.LandingPageSurvey();
        }
        public void CreateEntry(Survey survey)
        {
            surveyRepo.CreateEntry(survey);
        }

        public void CreateQuestions(List<SurveyQuestion> surveyQuestions, List<SurveyQuestionOption> optionList)
        {
            surveyRepo.CreateQuestions(surveyQuestions, optionList);
        }
        
        public Survey GetSurveyById(int id)
        {
            return surveyRepo.GetSurveyById(id);
        }

        public List<object> GetSurveyQuestionList()
        {
            return surveyRepo.GetSurveyQuestionList();
        }
    }
}
