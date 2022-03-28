#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_review_2022.Model;

namespace Razor_review_2022.Pages.School
{
    public class DetailsModel : PageModel
    {
        private readonly DBContext _context;

        public DetailsModel(DBContext context)
        {
            _context = context;
        }

        public Razor_review_2022.Model.School School { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            School = await _context.School.FirstOrDefaultAsync(m => m.SchoolId == id);

            if (School == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
