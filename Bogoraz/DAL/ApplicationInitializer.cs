using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bogoraz.Models;

namespace Bogoraz.DAL
{
    public class ApplicationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var applications = new List<Application>
            {
                new Application{FirstName="John", LastName="Dow", Address="955 First Ave", City="New York", State="New York", Zip=11204, HomePhone=7185958855, CellPhone=7188689559, DOB=DateTime.Parse("1974-06-12"), SSN=073509668, DDLID=123456789, DDLIDState="New York", ApplicationtDate=DateTime.Parse("2017-07-30")}
            };

            applications.ForEach(s => context.Applications.Add(s));
            context.SaveChanges();
        }
    }
}