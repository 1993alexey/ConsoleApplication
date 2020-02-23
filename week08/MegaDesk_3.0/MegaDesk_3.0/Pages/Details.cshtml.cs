using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_3._0.Models;

namespace MegaDesk_3._0.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly QuoteContext _context;

        public DetailsModel(QuoteContext context)
        {
            _context = context;
        }

        public QuoteModel QuoteModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QuoteModel = await _context.QuoteModel.FirstOrDefaultAsync(m => m.ID == id);

            if (QuoteModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
