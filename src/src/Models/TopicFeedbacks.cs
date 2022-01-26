using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebCourseRepo.Models
{
    public class TopicFeedbacks : Entity
    {
        [Required]
        public string Feedback { get; set; }

        [Required]
        public ICollection<Topics> Topics { get; set; }
    }
}
