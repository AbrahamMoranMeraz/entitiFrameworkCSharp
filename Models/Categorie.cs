namespace project.Model
{
    public class Categorie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IList<TaskM> Tasks { get; set; }
    }
}