﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

#nullable disable

namespace LyBooking.DTO
{
    public partial class RoomDto
    {
        public decimal Id { get; set; }
        public string SiteGuid { get; set; }
        public string HallGuid { get; set; }
        public string Type { get; set; }
        public string RoomNo { get; set; }
        public string RoomName { get; set; }
        public decimal? RoomSize { get; set; }
        public string RoomPhoto { get; set; }
        public string RoomDescript { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceMember { get; set; }
        public decimal? PriceSpecial { get; set; }
        public string RoomLocation { get; set; }
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public decimal? UpdateBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public decimal? DeleteBy { get; set; }
        public decimal? Status { get; set; }
        public string Guid { get; set; }
        public string RoomPhoto1 { get; set; }
        public string RoomPhoto2 { get; set; }
        public string RoomPhoto3 { get; set; }
        public string RoomPhoto4 { get; set; }
        public string RoomPhoto5 { get; set; }
        public List<IFormFile> File { get; set; }
        public List<IFormFile> RoomGallery { get; set; }
    }
}
