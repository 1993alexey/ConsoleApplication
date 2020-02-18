using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages
{
    public class CreateModel : PageModel
    {
        private readonly JournalDbContext _context;

        public CreateModel(JournalDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JournalModel JournalModel { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            JournalModel.CreatedAt = DateTime.Now;
            _context.JournalModel.Add(JournalModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
