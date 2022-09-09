using LyBooking.Models.Abstracts;
using LyBooking.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LyBooking.Models
{
    [Table("ToDoList")]
    public class ToDoList: AuditEntity
    {
        [Key]
        public int ID { get; set; }

    }
}
