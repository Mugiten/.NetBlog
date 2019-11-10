using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmptyFlow.Models;

namespace EmptyFlow.Pages
{
    public class EditModel : PageModel
    {
        private readonly EmptyFlow.Models.EmptyFlowContext _context;

        public EditModel(EmptyFlow.Models.EmptyFlowContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BlogPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostExists(BlogPost.ID))
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

        private bool BlogPostExists(int id)
        {
            return _context.BlogPost.Any(e => e.ID == id);
        }
    }
}
