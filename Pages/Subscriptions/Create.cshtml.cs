using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Alexandru_Aurel_Proiect.Data;
using Pop_Alexandru_Aurel_Proiect.Models;

namespace Pop_Alexandru_Aurel_Proiect.Pages.Subscriptions
{
    public class CreateModel : PageModel
    {
        private readonly Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext _context;

        public CreateModel(Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "Email");
        ViewData["SubscriptionTypeId"] = new SelectList(_context.SubscriptionType, "SubscriptionTypeId", "Name");
            return Page();
        }

        [BindProperty]
        public Subscription Subscription { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Subscription.Add(Subscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
