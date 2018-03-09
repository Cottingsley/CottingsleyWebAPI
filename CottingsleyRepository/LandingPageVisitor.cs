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
            throw new NotImplementedException();
        }

        public List<Visitor> GetAll()
        {
            throw new NotImplementedException();
        }

        public School GetSchoolByVisitorId(int userId)
        {
            throw new NotImplementedException();
        }

        public Survey GetSurveyByVisitorId(int userId)
        {
            throw new NotImplementedException();
        }

        public Visitor GetVisitorByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Visitor GetVisitorById(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Visitor> GetVisitorListByDesignation(string designation)
        {
            throw new NotImplementedException();
        }
    }
}
