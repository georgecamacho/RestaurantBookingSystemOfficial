using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystemOfficial.Data;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Pages.Payments
{
    public class DetailsModel : PageModel
    {
        private readonly RestaurantBookingSystemOfficial.Data.RestaurantContext _context;

        public DetailsModel(RestaurantBookingSystemOfficial.Data.RestaurantContext context)
        {
            _context = context;
        }

        public Payment Payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Payment = await _context.Payment.FirstOrDefaultAsync(m => m.PaymentID == id);

            if (Payment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
