using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyRepository
{
    public class LandingPageSchool : ILandingPageSchool
    {
        
        public void CreateEntry(School school)
        {
            using (var landingPageContext = new LandingPage())
            {
                landingPageContext.SchoolEntities.Add(school);
                landingPageContext.SaveChanges();
            }
        }

        public List<School> GetAll()
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.SchoolEntities.ToList();
            }
        }

        public School GetSchoolById(int schoolId)
        {
            using (var landingPageContext = new LandingPage())
            {
                return landingPageContext.SchoolEntities.Where(x=> x.Id == schoolId).FirstOrDefault();
            }
        }
    }
}
