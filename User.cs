using animal_clinic.Controllers;

namespace YourProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Един потребител може да има няколко домашни любимеца
        public List<Pet> Pets { get; set; }
    }
}
