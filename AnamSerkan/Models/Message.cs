using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("Messages")]
public partial class Message
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

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AnamSerkan.Models
//{
//    public class Message
//    {
//        public string Name { get; set; }
//        public string Email { get; set; }
//        public string PhoneNumber { get; set; }
//        public string Title { get; set; }
//        public string MessageDetail { get; set; }
//        public string SecurityCode { get; set; }
//    }
//}

