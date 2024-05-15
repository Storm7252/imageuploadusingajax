using System.ComponentModel.DataAnnotations.Schema;

namespace ajax_form_and_validation.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        [NotMapped]
        public IFormFile imagefile { get; set; }

        public string imageurl { get; set; }
    }
}
