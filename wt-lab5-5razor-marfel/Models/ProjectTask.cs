using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_marfel.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название обязательно")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Укажите исполнителя")]
        public string Assignee { get; set; } = string.Empty;

        public string Priority { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}