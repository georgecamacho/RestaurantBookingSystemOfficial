using System.ComponentModel.DataAnnotations;
using RestaurantBookingSystem.Models;

namespace RestaurantBookingSystemOfficial.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        [Required]
        public DateTime BookingDateTime { get; set; }
        public int PaymentID { get; set; }
        public int GuestID { get; set; }
        [Required]
        public Guest Guest { get; set; }
        public Payment Payment { get; set;}

    }
}