namespace ResumeBuilder.Shared.Interfaces
{
    public interface IAddress
    {
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
    }
}