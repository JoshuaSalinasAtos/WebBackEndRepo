using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    public class Sections : Entity
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(150)]
        public string? Description { get; set; }
        
        [Required]
        public int Number { get; set; }

        public double? Rating { get; set; }
        
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue(0)]
        public bool Deleted { get; set; }

        [Required]
        //IEnumerable/IList/ICollection
        public ICollection<Course> Course { get; set; }
        [Required]
        public ICollection<Status> Status { get; set; }

    }
}
