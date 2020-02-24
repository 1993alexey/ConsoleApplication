using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_3._0.Models;

namespace MegaDesk_3._0.Pages
{
    public class CreateModel : PageModel
    {
        private readonly QuoteContext _context;

        public CreateModel(QuoteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public QuoteModel QuoteModel { get; set; }
        public SelectList MaterialTypes {get; set;}



        public IActionResult OnGet()
        {
            MaterialTypes = new SelectList(QuoteModel.MaterialTypes);
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

            

            //QuoteModel.Date = DateTime.Now;

            _context.QuoteModel.Add(QuoteModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
