using CottingsleyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottingsleyContracts
{
    public interface ILandingPageVisitor
    {
        void CreateEntry(Visitor user);
        Visitor GetVisitorById(int userId);
        Visitor GetVisitorByEmail(string email);
        List<Visitor> GetVisitorListByDesignation(string designation);
        School GetSchoolByVisitorId(int userId);
        Survey GetSurveyByVisitorId(int userId);
        List<Visitor> GetAll();
    }
}
