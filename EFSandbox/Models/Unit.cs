namespace EFSandbox.Models
{
    public class Unit
    {
        public int Id { get; set; }

        public int ContainerId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = "Standard";
    }
}
