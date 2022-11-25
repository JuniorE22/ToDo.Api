namespace ToDoApi.Entities
{
    public class TaskStep
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public TaskStep()
        {

        }
        public TaskStep(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
