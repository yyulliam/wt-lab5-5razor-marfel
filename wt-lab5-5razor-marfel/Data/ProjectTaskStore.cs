using wt_lab5_5razor_marfel.Models;

namespace wt_lab5_5razor_marfel.Data
{
    public static class ProjectTaskStore
    {
        public static List<ProjectTask> Tasks { get; } = new()
        {
            new ProjectTask { Id = 1, Title = "Разработать API", Assignee = "Иван", Priority = "High", IsCompleted = false },
            new ProjectTask { Id = 2, Title = "Написать тесты", Assignee = "Анна", Priority = "Medium", IsCompleted = true },
            new ProjectTask { Id = 3, Title = "Обновить документацию", Assignee = "Петр", Priority = "Low", IsCompleted = false },
            new ProjectTask { Id = 4, Title = "Настроить CI/CD", Assignee = "Мария", Priority = "High", IsCompleted = false },
            new ProjectTask { Id = 5, Title = "Код-ревью", Assignee = "Алексей", Priority = "Medium", IsCompleted = true }
        };
    }
}