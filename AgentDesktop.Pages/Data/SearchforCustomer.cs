using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AgentDesktopFramework.Pages;

namespace AgentDesktop.Pages.Pages
{
    public class SearchforCustomer
    {
        public SearchforCustomer()
        {
            Title = "Mr";
            FirstName = "Ryu";
            LastName = "Ali";
            Postcode = "LU1";
            Country = "AFG";
            Email = "jahangir.ali@easyjet.com";
            EJPlusNumber = "12345678";
            FlightNumber = "012345678";
                       
        }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string EJPlusNumber { get; set; }
        public string FlightNumber { get; set; }
    }
}
