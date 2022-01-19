using System.ComponentModel.DataAnnotations;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    public class TopicFeedbacks : Entity
    {
        [Required]
        public string Feedback { get; set; }

        [Required]
        public ICollection<Topics> Topics { get; set; }
    }
}
