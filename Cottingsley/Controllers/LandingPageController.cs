using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CottingsleyModel;
using CottingsleyService;
using CottingsleyContracts;
using System.Collections.ObjectModel;
using System.Collections;

namespace Cottingsley.Controllers
{
    [RoutePrefix("api/LandingPage")]
    public class LandingPageController : ApiController
    {
        // GET: api/LandingPage
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LandingPage/5
        public string Get(int id)
        {
            return "value";
        }
        
        [Route("GetQuestions")]
        public IHttpActionResult GetQuestions() {
            try
            {
                ILandingPageSurvey surveyService = new LandingPageSurvey();
                List<SurveyQuestion> surveyQuestionList = new List<SurveyQuestion>() { new SurveyQuestion
                {
                    Id = 1,
                    Question = "What is what?"

                }};
                List<SurveyQuestionOption> surveyQuestionOptions = new List<SurveyQuestionOption>() {
                        new SurveyQuestionOption {
                        Id=1,
                        Option="option1",
                        SurveyQuestionId=1
                        },
                        new SurveyQuestionOption {
                        Id=2,
                        Option="option2",
                        SurveyQuestionId=1
                        }
                    };
                surveyService.CreateQuestions(surveyQuestionList, surveyQuestionOptions);
                
                return Json(new Response
                {
                    Message = "Data received successfuly",
                    Status = true,
                    Data = surveyService.GetSurveyQuestionList()
                });
                //return new Response
                //{
                //    Message = "Data received successfuly",
                //    Status = true,
                //    Data = surveyService.GetSurveyQuestionList()
                //};

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // POST: api/LandingPage
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LandingPage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LandingPage/5
        public void Delete(int id)
        {
        }
    }
}
