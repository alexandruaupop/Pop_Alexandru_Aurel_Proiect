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
    public class IndexModel : PageModel
    {
        private readonly Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext _context;

        public IndexModel(Pop_Alexandru_Aurel_Proiect.Data.Pop_Alexandru_Aurel_ProiectContext context)
        {
            _context = context;
        }

        public IList<SubscriptionType> SubscriptionType { get;set; } = default!;

        public async Task OnGetAsync()
        {
            SubscriptionType = await _context.SubscriptionType.ToListAsync();
        }
    }
}
