namespace CottingsleyRepository
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LandingPage : DbContext
    {
        // Your context has been configured to use a 'LandingPage' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CottingsleyRepository.LandingPage' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LandingPage' 
        // connection string in the application configuration file.
        public LandingPage()
            : base("name=LandingPage")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<CottingsleyModel.School> SchoolEntities { get; set; }
        public virtual DbSet<CottingsleyModel.Survey> SurveyEntities { get; set; }
        public virtual DbSet<CottingsleyModel.SurveyAnswer> SurveyAnswerEntities { get; set; }
        public virtual DbSet<CottingsleyModel.SurveyQuestion> SurveyQuestionEntities { get; set; }
        public virtual DbSet<CottingsleyModel.Visitor> VisitorEntities { get; set; }
        public virtual DbSet<CottingsleyModel.SurveyQuestionOption> SurveyQuestionOptionEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}