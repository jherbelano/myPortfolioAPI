using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Users
    {
        [Column("UserId")]
        public Guid Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "Nick name is required.")]
        public string? Nickname { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Position is required.")]
        public string? Position { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }
        public string? ProfileUrl { get; set; }


        [ForeignKey(nameof(AboutMe))]
        public Guid AboutMeId { get; set; }
        public AboutMe? AboutMe { get; set; }
        public ICollection<Quotes>? Quotes { get; set; }
        public ICollection<Skills>? Skills { get; set; }
        public ICollection<Projects>? Projects { get; set; }
    }
}
