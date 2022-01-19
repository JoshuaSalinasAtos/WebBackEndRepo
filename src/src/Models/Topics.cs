using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    public class Topics : Entity
    {
        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public int Number { get; set; }

        public double Rating { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue(0)]
        public bool Deleted { get; set; }

        [Required]
        public ICollection<Sections> Sections { get; set; }
        [Required]
        public ICollection<Course> Course { get; set; }
        [Required]
        public ICollection<Status> Status { get; set; }
    }
}
