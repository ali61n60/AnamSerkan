using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnamSerkan.Models
{
    [Table("Messages")]
    public class Message
    {
        public int id { get; set; }

        [NotMapped]
        public string SecurityCode { get; set; }

        [Required]
        [StringLength(50)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        [Column("phone")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(250)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [StringLength(2500)]
        [Column("detail")]
        public string MessageDetail { get; set; }
    }
}