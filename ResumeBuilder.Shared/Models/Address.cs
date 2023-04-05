using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Address : IAddress
    {
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Zip { get; set; }
    }
}
