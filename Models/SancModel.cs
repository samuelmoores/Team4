using Microsoft.AspNetCore.DataProtection;

namespace Sanctum.Models
{
    public class SancModel
    {
        public string Booking { get; set; } = string.Empty;
        public int Availability { get; set; }
        public int Capacity { get; set; }
        public float Length { get; set; }
        public float TimeLimit {  get; set; }
    }
}
