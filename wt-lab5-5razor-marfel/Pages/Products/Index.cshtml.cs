using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_marfel.Data;
using wt_lab5_5razor_marfel.Models;

namespace wt_lab5_5razor_marfel.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<ProjectTask> Tasks { get; set; } = new();

        public void OnGet()
        {
            Tasks = ProjectTaskStore.Tasks;
        }
    }
}