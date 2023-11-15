using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystemOfficial.Data;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantBookingSystemOfficial.Data.RestaurantContext _context;

        public IndexModel(RestaurantBookingSystemOfficial.Data.RestaurantContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Bookings
                .Include(b => b.Payment).ToListAsync();
        }
    }
}
