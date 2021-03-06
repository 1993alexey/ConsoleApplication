using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages
{
    public class EditModel : PageModel
    {
        private readonly JournalDbContext _context;

        public EditModel(JournalDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JournalModel JournalModel { get; set; }
        private DateTime _creationTime { get; set; }

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

            _creationTime = JournalModel.CreatedAt;
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JournalModel).State = EntityState.Modified;
            _context.Attach(JournalModel).Entity.CreatedAt = _creationTime;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalModelExists(JournalModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JournalModelExists(int id)
        {
            return _context.JournalModel.Any(e => e.ID == id);
        }
    }
}
