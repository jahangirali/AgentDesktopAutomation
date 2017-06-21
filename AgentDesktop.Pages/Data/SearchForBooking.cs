using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentDesktop.Pages.Data
{
    class SearchForBooking
    {
        public SearchForBooking()
        {
            Title = "Mrs";
            FirstName = "Ryu";
            LastName = "Ali";
            Postcode = "LU1";
            Email = "jahangir.ali@easyjet.com";
            Postcode = "12345678";
            ContactNumber = "012345678";
            DateOfBirth = "01/01/1980";
            TravelDocType = "Passport";
            TravelDocRef = "X12345678";
        }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string TravelDocType { get; set; }
        public string TravelDocRef { get; set; }


    }
}
