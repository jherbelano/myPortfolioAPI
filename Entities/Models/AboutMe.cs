using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AboutMe
    {
        [Column("AboutMeId")]
        public Guid Id { get; set; }
        public string? PictureUrl { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }


        [ForeignKey(nameof(Users))]
        public Guid UserId { get; set; }
        public Users? User { get; set; }
    }
}
