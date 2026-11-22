using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_marfel.Data;
using wt_lab5_5razor_marfel.Models;

namespace wt_lab5_5razor_marfel.Pages.Products
{
    public class DetailsModel : PageModel
    {
        public ProjectTask? Task { get; set; }

        public IActionResult OnGet(int id)
        {
            Task = ProjectTaskStore.Tasks.FirstOrDefault(t => t.Id == id);
            if (Task == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}