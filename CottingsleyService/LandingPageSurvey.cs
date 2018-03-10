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
        
        public void CreateOptions(int QuestionId, List<SurveyQuestionOption> optionList)
        {
            surveyRepo.CreateOptions(QuestionId, optionList);
        }

        public void CreateQuestions(List<SurveyQuestion> surveyQuestions)
        {
            surveyRepo.CreateQuestions(surveyQuestions);
        }

        public List<SurveyQuestion> GetAllQuestions()
        {
            return surveyRepo.GetAllQuestions();
        }

        public SurveyQuestion GetQuestionById(int id)
        {
            return surveyRepo.GetQuestionById(id);
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
