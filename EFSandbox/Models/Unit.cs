namespace EFSandbox.Models
{
    public class Unit
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Type { get; set; } = "Standard";

        public Container Parent { get; set; }
        public int ParentId { get; set; }
    }
}
