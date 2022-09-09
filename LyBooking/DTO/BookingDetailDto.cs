﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LyBooking.DTO
{
    public partial class BookingDetailDto
    {
        public decimal Id { get; set; }
        public string BookingGuid { get; set; }
        public string HallGuid { get; set; }
        public string RoomGuid { get; set; }
        public string HallType { get; set; }
        public string RoomType { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingTimeS { get; set; }
        public string BookingTimeE { get; set; }
        public decimal? Alternate { get; set; }
        public string PrepareRice { get; set; }
        public string PrepareVegetarian { get; set; }
        public string PrepareFlower { get; set; }
        public string PrepareFruit { get; set; }
        public string PrepareTea { get; set; }
        public string PrepareFloral { get; set; }
        public string ChantingType { get; set; }
        public string InOut { get; set; }
        public decimal? MageMonk { get; set; }
        public decimal? HouseMonk { get; set; }
        public string Offerings { get; set; }
        public string MageMemo { get; set; }
        public string MageMoney { get; set; }
        public decimal? OrderMeal { get; set; }
        public string WorkOrderGuid { get; set; }
        public string FuneralDirector { get; set; }
        public string FuneralMemo { get; set; }
        public string OrderNo { get; set; }
        public string OrderName { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? UpdateBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public decimal? DeleteBy { get; set; }
        public decimal? Status { get; set; }
        public string Guid { get; set; }
        public string SiteGuid { get; set; }
    }
}