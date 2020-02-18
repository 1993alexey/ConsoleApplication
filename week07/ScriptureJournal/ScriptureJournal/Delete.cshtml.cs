using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal
{
    public class DeleteModel : PageModel
    {
        private readonly ScriptureJournalDbContext _context;

        public DeleteModel(ScriptureJournalDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JournalModel JournalModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JournalModel = await _context.JournalModel.FirstOrDefaultAsync(m => m.ID == id);

            if (JournalModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JournalModel = await _context.JournalModel.FindAsync(id);

            if (JournalModel != null)
            {
                _context.JournalModel.Remove(JournalModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
