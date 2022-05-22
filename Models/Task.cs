namespace project.Model
{
    public class TaskM
    {
        public Guid TaskID { get; set; }
        public Guid CategorieId { get; set; }
        public string Description { get; set; }
        public Priority PriorityTask { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Categorie Categorie { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        High,
    }
}