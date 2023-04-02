using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Address : IAddress
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
