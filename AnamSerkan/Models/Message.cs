using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("anamserk_ali.Messages")]
public partial class Message
{
    public int id { get; set; }

    [Required]
    [StringLength(50)]
    public string name { get; set; }

    [Required]
    [StringLength(250)]
    public string email { get; set; }

    [Required]
    [StringLength(50)]
    public string phone { get; set; }

    [Required]
    [StringLength(250)]
    public string title { get; set; }

    [Required]
    [StringLength(2500)]
    public string detail { get; set; }
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

