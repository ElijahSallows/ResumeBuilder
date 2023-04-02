namespace ResumeBuilder.Shared.Interfaces
{
    public interface IUserInfoModel
    {
        string About { get; set; }
        IAddress Address { get; set; }
        string Email { get; set; }
        List<ISocialLink> Links { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string Title { get; set; }
    }
}