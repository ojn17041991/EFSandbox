using EFSandbox.Data;
using EFSandbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFSandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly DataContext context;

        public ContainerController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("{containerId}")]
        public object Get(int containerId)
        {
            Container container = context.Containers.Single(c => c.Id == containerId);
            List<Unit> units = context.Units.Where(u => u.ContainerId == containerId).ToList();
            container.Units = units;
            return container;
        }

        //[HttpPost]
        //public string Post([FromBody] Unit unit)
        //{

        //}
    }
}
