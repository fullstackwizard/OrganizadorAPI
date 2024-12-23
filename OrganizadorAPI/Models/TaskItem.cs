namespace OrganizadorAPI.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = "General"; // Trabalho, Estudo ou Finanças
        public bool IsCompleted { get; set; } = false;
    }
}
