using LyBooking.Models.Abstracts;
using LyBooking.Models.Interface;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LyBooking.Models
{

    [Table("Plans")]
    public class Plan : AuditEntity
    {
        [Key]
        public int ID { get; set; }
     
      
      
    }
}
