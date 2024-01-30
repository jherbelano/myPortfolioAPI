using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProjectPhotos
    {
        [Column("ProjectPhotosId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Photo Url is required.")]
        public string? PhotoUrl { get; set; }


        [ForeignKey(nameof(Projects))]
        public Guid ProjectID { get; set; }
        public Projects? Project { get; set; }
    }
}
