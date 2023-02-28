using EFSandbox.Data;
using EFSandbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

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
            return getPopulatedContainer(containerId);
        }

        [HttpPost]
        public object Post([FromBody] Unit unit)
        {
            context.Units.Add(unit);
            context.SaveChanges();

            return getPopulatedContainer(unit.ContainerId);
        }

        // Hello world!

        private Models.Container getPopulatedContainer(int containerId)
        {
            Models.Container container = context.Containers.Single(c => c.Id == containerId);
            List<Unit> units = context.Units.Where(u => u.ContainerId == containerId).ToList();
            container.Units = units;
            return container;
        }
    }
}
