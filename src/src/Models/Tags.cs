using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebCourseRepo.Models;

namespace WebBackEndRepo.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Tags : Entity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DefaultValue(0)]
        public int Popularity { get; set; }

        [Required]
        public ICollection<Status> Status { get; set; }
    }
}
