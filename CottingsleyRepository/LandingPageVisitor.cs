using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyRepository
{
    public class LandingPageVisitor : ILandingPageVisitor
    {
        public void CreateEntry(Visitor user)
        {
            using (var landingPageContext = new LandingPage()) {
                landingPageContext.VisitorEntities.Add(user);
            }
        }

        public List<Visitor> GetAll()
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.ToList();
            }
        }

        public School GetSchoolByVisitorId(int userId)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.Where(x=> x.Id== userId).Select(y=>y.SchoolObj).FirstOrDefault();
            }
        }

        public Survey GetSurveyByVisitorId(int userId)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.Where(x => x.Id == userId).Select(y => y.SurveyObj).FirstOrDefault();
            }
        }

        public Visitor GetVisitorByEmail(string email)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.Where(x => x.Email == email).FirstOrDefault();
            }
        }

        public Visitor GetVisitorById(int userId)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.Where(x => x.Id == userId).FirstOrDefault();
            }
        }

        public List<Visitor> GetVisitorListByDesignation(string designation)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.VisitorEntities.Where(x => x.Designation == designation).ToList();
            }
        }
    }
}
