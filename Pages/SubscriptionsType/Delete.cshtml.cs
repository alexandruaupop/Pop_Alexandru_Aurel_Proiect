using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Alexandru_Aurel_Proiect.Data;
using Pop_Alexandru_Aurel_Proiect.Models;

namespace Pop_Alexandru_Aurel_Proiect.Pages.SubscriptionsType
{
    public class DeleteModel : PageModel
    {
        private readonly Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext _context;

        public DeleteModel(Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubscriptionType SubscriptionType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriptiontype = await _context.SubscriptionType.FirstOrDefaultAsync(m => m.SubscriptionTypeId == id);

            if (subscriptiontype == null)
            {
                return NotFound();
            }
            else
            {
                SubscriptionType = subscriptiontype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subscriptiontype = await _context.SubscriptionType.FindAsync(id);
            if (subscriptiontype != null)
            {
                SubscriptionType = subscriptiontype;
                _context.SubscriptionType.Remove(SubscriptionType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
