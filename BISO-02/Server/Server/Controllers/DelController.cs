using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelController : ControllerBase
    {
        // POST api/<DelController>
        [HttpPost]
        public void Post([FromBody] int id)
        {
            Console.WriteLine("ыыЫыыЫыы");
			Console.WriteLine(Program.ms.GetCountMessages());
            Program.ms.Del(id);
            Console.WriteLine($"{id} сообщение было удалено.");
			Console.WriteLine(Program.ms.GetCountMessages());
        }
    }
}
