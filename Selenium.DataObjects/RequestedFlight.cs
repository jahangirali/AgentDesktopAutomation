using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.DataObjects
{
    class RequestedFlight
    {
        public RequestedFlight()
        {
            DepartureDate = DateTime.Today.AddDays(4).AddHours(6).AddMinutes(0).AddSeconds(0);
            ReturnDate = DateTime.Today.AddDays(11).AddHours(10).AddMinutes(0).AddSeconds(0);
            DepartureAirportName = "London Gatwick";
            DestinationAirportName = "Barcelona";
            DepartureAirportCode = "LGW";
            DestinationAirportCode = "BCN";
            IsReturn = false;
            Flexi = false;
            NumberOfAdults = 1;
            NumberOfChildren = 0;
            NumberOfInfants = 0;
        }
    
    public string DestinationAirportCode { get; set; }
    public string DepartureAirportCode { get; set; }
    public string DestinationAirportName { get; set; }
    public string DepartureAirportName { get; set; }
    public bool Flexi { get; set; }
    public DateTime ReturnDate { get; set; }
    public bool IsReturn { get; set; }
    public string DestinationAirport => $"{DestinationAirportName} ({DestinationAirportCode})";
    public string DepartureAirport => $"{DepartureAirportName} ({DepartureAirportCode})";
    public DateTime DepartureDate { get; set; }
    public int NumberOfAdults { get; set; }
    public int NumberOfChildren { get; set; }
    public int NumberOfInfants { get; set; }
}
    }

