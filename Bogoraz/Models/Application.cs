using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bogoraz.Models
{
    public class Application
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long HomePhone { get; set; }
        public long CellPhone { get; set; }
        public DateTime DOB { get; set; }
        public long SSN { get; set; }
        public long DDLID { get; set; }
        public string DDLIDState { get; set; }
        public string DocumentName { get; set; }
        public DateTime ApplicationtDate { get; set; }
    }
}