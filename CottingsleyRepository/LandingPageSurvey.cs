using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyRepository
{
    public class LandingPageSurvey : ILandingPageSurvey
    {
        
        public void CreateEntry(Survey survey)
        {
            using (var landingPageContext = new LandingPage())
            {
                landingPageContext.SurveyEntities.Add(survey);
                landingPageContext.SaveChanges();
            }
        }

        public void CreateOptions(int QuestionId, List<SurveyQuestionOption> optionList)
        {
            for (int i = 0; i < optionList.Count; i++)
            {
                var obj = optionList[i];
                obj.SurveyQuestionId = QuestionId;
                using (var landingPageContext = new LandingPage())
                {
                    landingPageContext.SurveyQuestionOptionEntities.Add(obj);
                    landingPageContext.SaveChanges();
                }
            }
            
        }

        public void CreateQuestions(List<SurveyQuestion> surveyQuestions)
        {
            using (var landingPageContext = new LandingPage())
            {
                foreach (var item in surveyQuestions)
                {
                    landingPageContext.SurveyQuestionEntities.Add(item);
                    landingPageContext.SaveChanges();
                }
            }
        }

        public List<SurveyQuestion> GetAllQuestions()
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.SurveyQuestionEntities.ToList();
            }
        }

        public SurveyQuestion GetQuestionById(int id)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.SurveyQuestionEntities.Where(x=> x.Id==id).FirstOrDefault();
            }
        }

        public Survey GetSurveyById(int id)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.SurveyEntities.Where(x=> x.Id == id).FirstOrDefault();
            }
        }

        public List<object> GetSurveyQuestionList()
        {
            using (var landingPageContext = new LandingPage())
            {
                List<object> objectlist = new List<object> { new { Question = string.Empty,Options=new List<SurveyQuestionOption>() } };
                List<SurveyQuestion> surveyquestionlist= landingPageContext.SurveyQuestionEntities.ToList();
                objectlist.RemoveAt(0);
                foreach (var item in surveyquestionlist)
                {
                    objectlist.Add(new
                    {
                        Question = item.Question,
                        Options = landingPageContext.SurveyQuestionOptionEntities.Where(x => x.SurveyQuestionId == item.Id).ToList()
                    });
                    
                }
                return objectlist;
            }
        }
    }
}
