﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LyBooking.Models
{
    public partial class CodeServiceType
    {
        public decimal Id { get; set; }
        public string CodeNo { get; set; }
        public string CodeName { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public decimal? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Sort { get; set; }
    }
}
