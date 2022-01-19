using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class TopicTypes : Entity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
