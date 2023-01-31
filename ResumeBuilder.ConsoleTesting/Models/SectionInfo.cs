namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class SectionInfo<T>
    {
        public string? Name { get; set; }
        public List<T> Bullets { get; set; }
        public SectionInfo()//string? name, List<T> bullets)
        {
            //Name = name;
            //Bullets = bullets;
        }
    }
}
