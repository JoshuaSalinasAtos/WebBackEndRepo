using System.ComponentModel.DataAnnotations;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    public class CoursesTags : Entity
    {
        [Required]
        public ICollection<Course> Course { get; set; }
        [Required]
        public ICollection<Tags> Tags { get; set; }
    }
}
