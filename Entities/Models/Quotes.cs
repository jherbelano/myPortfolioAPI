using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models 
{ 
    public class Quotes
    {
        [Column("QuotesId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Quote is required.")]
        public string? Quote { get; set; }
        public string? Author { get; set; }


        [ForeignKey(nameof(Users))]
        public Guid UserID { get; set; }
        public Users? User { get; set; }
    }
}
