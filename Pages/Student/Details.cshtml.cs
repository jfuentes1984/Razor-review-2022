#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_review_2022.Model;

namespace Razor_review_2022.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly DBContext _context;

        public DetailsModel(DBContext context)
        {
            _context = context;
        }

        public Razor_review_2022.Model.Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.StudentId == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
