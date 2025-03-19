namespace YourProject.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Куче, Котка и т.н.
        public int Age { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
    }
}
