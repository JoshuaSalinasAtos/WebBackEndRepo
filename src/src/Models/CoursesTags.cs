using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebCourseRepo.Models
{
    public class CoursesTags : Entity
    {
        [Required]
        public ICollection<Course> Course { get; set; }
        [Required]
        public ICollection<Tags> Tags { get; set; }
    }
}
