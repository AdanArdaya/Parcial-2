using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Friend
    {
        [Key]
        
        public string FrienId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int NikName { get; set; }
        [Required]
        public DataType Birthday { get; set; }
    }
}