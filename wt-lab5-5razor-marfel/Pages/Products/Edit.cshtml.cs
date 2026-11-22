using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_marfel.Data;
using wt_lab5_5razor_marfel.Models;

namespace wt_lab5_5razor_marfel.Pages.Products
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ProjectTask Task { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var existing = ProjectTaskStore.Tasks.FirstOrDefault(t => t.Id == id);
            if (existing == null) return NotFound();

            Task = existing;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var existing = ProjectTaskStore.Tasks.FirstOrDefault(t => t.Id == Task.Id);
            if (existing == null) return NotFound();

            existing.Title = Task.Title;
            existing.Assignee = Task.Assignee;
            existing.Priority = Task.Priority;
            existing.IsCompleted = Task.IsCompleted;

            return RedirectToPage("./Index");
        }
    }
}