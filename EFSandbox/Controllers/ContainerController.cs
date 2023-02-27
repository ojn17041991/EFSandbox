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

        [HttpGet("{id}")]
        public object Get(int id)
        {
            return context.Units.Where(u => u.ParentId == id);
        }

        //[HttpPost]
        //public string Post([FromBody] Unit unit)
        //{

        //}
    }
}
