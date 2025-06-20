using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_PROJECT.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public string Course { get; set; }
    }
}
