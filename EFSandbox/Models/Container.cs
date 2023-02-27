namespace EFSandbox.Models
{
    public class Container
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Unit> Units { get; set; }
    }
}
