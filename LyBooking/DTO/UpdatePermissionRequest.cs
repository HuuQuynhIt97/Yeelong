using System.Collections.Generic;


namespace LyBooking.DTO
{
    public class UpdatePermissionRequest
    {
        public List<PermissionDto> Permissions { get; set; } = new List<PermissionDto>();
    }
}
