namespace ResumeBuilder.ConsoleTesting.Models
{
    public class UserInfo
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Address? Address { get; set; }
        public List<SocialLink>? Links { get; set; }
        public string? About { get; set; }
    }
}
