using System.ComponentModel.DataAnnotations;
using RestaurantBookingSystem.Models;

namespace RestaurantBookingSystemOfficial.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int PaymentID { get; set; }
        public int GuestID { get; set; }
        public int TableID { get; set; }

        public int BookingCapacity { get; set; }
        public DateTime BookingDateTime { get; set; }

        public Guest Guest { get; set; }
        public Payment Payment { get; set;}
        public Table Table { get; set; }

    }
}