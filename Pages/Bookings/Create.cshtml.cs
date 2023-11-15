using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantBookingSystemOfficial.Data;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly RestaurantBookingSystemOfficial.Data.RestaurantContext _context;

        public CreateModel(RestaurantBookingSystemOfficial.Data.RestaurantContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PaymentID"] = new SelectList(_context.Payment, "PaymentID", "PaymentID");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bookings.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
