using CottingsleyContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CottingsleyModel;

namespace CottingsleyService
{
    public class LandingPageVisitor : ILandingPageVisitor
    {
        ILandingPageVisitor visitorRepo;
        public LandingPageVisitor() {
            visitorRepo = new CottingsleyRepository.LandingPageVisitor();
        }

        public void CreateEntry(Visitor user)
        {
            visitorRepo.CreateEntry(user);
        }

        public List<Visitor> GetAll()
        {
            return visitorRepo.GetAll();
        }

        public School GetSchoolByVisitorId(int userId)
        {
            return visitorRepo.GetSchoolByVisitorId(userId);
        }

        public Survey GetSurveyByVisitorId(int userId)
        {
            return visitorRepo.GetSurveyByVisitorId(userId);
        }

        public Visitor GetVisitorByEmail(string email)
        {
            return visitorRepo.GetVisitorByEmail(email);
        }

        public Visitor GetVisitorById(int userId)
        {
            return visitorRepo.GetVisitorById(userId);
        }

        public List<Visitor> GetVisitorListByDesignation(string designation)
        {
            return visitorRepo.GetVisitorListByDesignation(designation);
        }
    }
}
