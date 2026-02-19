using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_Alexandru_Aurel_Proiect.Data;
using Pop_Alexandru_Aurel_Proiect.Models;

namespace Pop_Alexandru_Aurel_Proiect.Pages.Trainers
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
            return Page();
        }

        [BindProperty]
        public Trainer Trainer { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trainer.Add(Trainer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
