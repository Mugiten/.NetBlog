using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmptyFlow.Models;

namespace EmptyFlow.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly EmptyFlow.Models.EmptyFlowContext _context;

        public DeleteModel(EmptyFlow.Models.EmptyFlowContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogPost = await _context.BlogPost.FirstOrDefaultAsync(m => m.ID == id);

            if (BlogPost == null)
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

            BlogPost = await _context.BlogPost.FindAsync(id);

            if (BlogPost != null)
            {
                _context.BlogPost.Remove(BlogPost);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
