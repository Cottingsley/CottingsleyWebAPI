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

        /// <summary>
        /// Get only questions
        /// </summary>
        /// <returns></returns>
        [Route("GetAllQuestions")]
        public IHttpActionResult GetAllOnlyQuestions() {
            try
            {
                ILandingPageSurvey surveyService = new LandingPageSurvey();
                return Json(new Response
                {
                    Message = "Data received successfuly",
                    Status = true,
                    Data = surveyService.GetAllQuestions()
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Get Question with options
        /// </summary>
        /// <returns></returns>
        [Route("GetSurveyQuestions")]
        public IHttpActionResult GetSurveyQuestions() {
            try
            {
                ILandingPageSurvey surveyService = new LandingPageSurvey();
                return Json(new Response
                {
                    Message = "Data received successfuly",
                    Status = true,
                    Data = surveyService.GetSurveyQuestionList()
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get single question by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetSurveyQuestionsById")]
        public IHttpActionResult GetSurveyQuestionsById(int id)
        {
            try
            {
                ILandingPageSurvey surveyService = new LandingPageSurvey();
                return Json(new Response
                {
                    Message = "Data received successfuly",
                    Status = true,
                    Data = surveyService.GetQuestionById(id)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Post Questions
        /// </summary>
        /// <param name="surveyQuestionList"></param>
        /// <returns></returns>
        [Route("PostSurveyQuestions")]
        public IHttpActionResult PostSurveyQuestions(List<SurveyQuestion> surveyQuestionList) {
            try
            {
                ILandingPageSurvey surveyService = new LandingPageSurvey();
                surveyService.CreateQuestions(surveyQuestionList);
                return Json(new Response
                {
                    Message = "Questions created successfuly",
                    Status = true,
                    Data = null
                });
            }
            catch (Exception e) {
                throw e;
            }
        }

        /// <summary>
        /// Create options of a question
        /// </summary>
        /// <param name="questionId"></param>
        /// <param name="surveyQuestionOptions"></param>
        /// <returns></returns>
        [Route("PostSurveyOptions")]
        public IHttpActionResult PostSurveyOptions(int questionId, List<SurveyQuestionOption> surveyQuestionOptions)
        {
            ILandingPageSurvey surveyService = new LandingPageSurvey();
            surveyService.CreateOptions(questionId, surveyQuestionOptions);
            return Json(new Response
            {
                Message = "Questions created successfuly",
                Status = true,
                Data = null
            });
        }
        
    }
}
