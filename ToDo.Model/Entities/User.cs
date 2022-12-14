namespace ToDoApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public User(string name, string username, string password)
        {
            Name = name;
            UserName = username;
            Password = password;
        }
    }
}
