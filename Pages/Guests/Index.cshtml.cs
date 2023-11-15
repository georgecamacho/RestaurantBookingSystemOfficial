using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystemOfficial.Data;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Pages.Guests
{
    public class IndexModel : PageModel
    {
        private readonly Data.RestaurantContext _context;

        public IndexModel(Data.RestaurantContext context)
        {
            _context = context;
        }

        public IList<Guest> Guest { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Guests != null)
            {
                Guest = await _context.Guests.ToListAsync();
            }
        }
    }
}
