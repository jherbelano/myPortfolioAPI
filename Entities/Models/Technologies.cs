using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Technologies
    {
        [Column("TechologyId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }


        [ForeignKey(nameof(Projects))]
        public Guid ProjectID { get; set; }
        public Projects? Project { get; set; }
    }
}
