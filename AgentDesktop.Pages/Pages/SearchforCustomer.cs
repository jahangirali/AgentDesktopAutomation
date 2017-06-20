using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentDesktop.Pages.Pages
{
    public class SearchforCustomer
    {
        public SearchforCustomer()
        {
            FirstName = "Ryu";
            LastName = "Ali";
            Postcode = "LU1";
            Email = "jahangir.ali@easyjet.com";
            EJPlusNumber = "12345678";
            FlightNumber = "012345678";
            
            //customerSearchPage.ClickSearchButton();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string EJPlusNumber { get; set; }
        public string FlightNumber { get; set; }
    }
}
