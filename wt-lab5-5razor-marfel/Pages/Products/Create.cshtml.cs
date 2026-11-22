using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_marfel.Data;
using wt_lab5_5razor_marfel.Models;

namespace wt_lab5_5razor_marfel.Pages.Products
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ProjectTask Task { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Task.Id = ProjectTaskStore.Tasks.Any() ? ProjectTaskStore.Tasks.Max(t => t.Id) + 1 : 1;
            ProjectTaskStore.Tasks.Add(Task);

            return RedirectToPage("./Index");
        }
    }
}