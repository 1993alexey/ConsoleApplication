using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly JournalDbContext _context;

        public DetailsModel(JournalDbContext context)
        {
            _context = context;
        }

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
    }
}
