using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyService
{
    public class LandingPageSchool : ILandingPageSchool
    {
        ILandingPageSchool schoolRepo;
        public LandingPageSchool() {            
            schoolRepo = new CottingsleyRepository.LandingPageSchool();
        }
        public void CreateEntry(School school)
        {
            schoolRepo.CreateEntry(school);
        }

        public List<School> GetAll()
        {
            return schoolRepo.GetAll();
        }

        public School GetSchoolById(int schoolId)
        {
            return schoolRepo.GetSchoolById(schoolId);
        }

        public School GetSchoolByName(string schoolName)
        {
            return schoolRepo.GetSchoolByName(schoolName);
        }
    }
}
