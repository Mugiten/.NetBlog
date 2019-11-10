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
    public class DetailsModel : PageModel
    {
        private readonly EmptyFlow.Models.EmptyFlowContext _context;

        public DetailsModel(EmptyFlow.Models.EmptyFlowContext context)
        {
            _context = context;
        }

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
    }
}
