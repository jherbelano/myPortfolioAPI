using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Projects
    {
        [Column("ProjectId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? description { get; set; }
        

        [ForeignKey(nameof(Users))]
        public Guid UserID { get; set; }
        public Users? User { get; set; }


        public ICollection<Technologies>? Technologies { get; set; }
        public ICollection<ProjectPhotos>? ProjectPhotos { get; set; }
        
    }
}
