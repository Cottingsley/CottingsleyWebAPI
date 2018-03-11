using CottingsleyContracts;
using CottingsleyModel;
using CottingsleyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cottingsley.Controllers
{
    [RoutePrefix("api/School")]
    public class SchoolController : ApiController
    {
        // GET: api/School
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/School/5
        
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/School
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT: api/School/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/School/5
        public void Delete(int id)
        {
        }

        
        [Route("Create")]
        [HttpPost]
        public IHttpActionResult PostSchool([FromBody]School school) {
            try
            {
                ILandingPageSchool schoolService = new LandingPageSchool();
                schoolService.CreateEntry(school);
                return Json(new Response
                {
                    Message = "School created",
                    Data = null,
                    Status = true
                });
            }
            catch (Exception e) {
                throw e;
            }
            
        }

        [HttpPost]
        [Route("GetAllSchools")]
        public IHttpActionResult GetAllSchools() {
            try
            {
                ILandingPageSchool schoolService = new LandingPageSchool();
                return Json(new Response
                {
                    Message = "All school data",
                    Data = schoolService.GetAll(),
                    Status = true
                });
                
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        [Route("GetSchoolId/id")]
        public IHttpActionResult GetSchoolById(int id)
        {
            try
            {
                ILandingPageSchool schoolService = new LandingPageSchool();
                return Json(new Response
                {
                    Message = "School data by id",
                    Data = schoolService.GetSchoolById(id),
                    Status = true
                });

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
