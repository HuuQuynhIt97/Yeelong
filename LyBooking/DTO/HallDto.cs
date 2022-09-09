﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LyBooking.DTO
{
    public partial class HallDto
    {
        public decimal Id { get; set; }
        public string SiteGuid { get; set; }
        public string Type { get; set; }
        public string HallNo { get; set; }
        public string HallName { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? UpdateBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public decimal? DeleteBy { get; set; }
        public decimal? Status { get; set; }
        public string Guid { get; set; }
    }
}
