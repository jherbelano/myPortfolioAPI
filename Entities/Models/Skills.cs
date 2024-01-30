using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Skills
    {
        [Column("SkillId")]
        public Guid Id { get; set; }
        
        public string? LogoUrl { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }
        public int Rate { get; set; }


        [ForeignKey(nameof(Users))]
        public Guid UserID { get; set; }
        public Users? User { get; set; }
    }
}
