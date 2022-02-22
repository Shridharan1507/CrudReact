using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table(name: "Profile")]
    public class Profile
    {
        [Key]
        public long ID { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Customer_Name { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Mobile { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime InsertedDate { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Column(TypeName = "bigint")]
        public long InsertedId { get; set; }
        [Column(TypeName = "bigint")]
        public long ModifiedId { get; set; }
        [Column(TypeName = "bit")]
        public bool Active { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }
        [Column(TypeName = "bit")]
        public bool IsAvailable { get; set; }

    }
}