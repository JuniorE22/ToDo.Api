namespace ToDoApi.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Description { get; set; }

        public Task()
        {

        }
        public Task(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
