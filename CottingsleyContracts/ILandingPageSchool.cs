using CottingsleyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottingsleyContracts
{
    public interface ILandingPageSchool
    {
        void CreateEntry(School school);
        School GetSchoolById(int schoolId);
        School GetSchoolByName(string schoolName);
        List<School> GetAll();
    }
}