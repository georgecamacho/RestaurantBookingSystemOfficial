using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystem.Models
{
    public class Table
    {
        public int TableID { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Capacity must be in between 1 - 15 (inclusive)")]
        public int Capacity { get; set; }
    }
}