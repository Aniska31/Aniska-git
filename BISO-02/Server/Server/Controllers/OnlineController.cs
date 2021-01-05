using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineController : ControllerBase
    {
        // POST api/<OnlineController>
        [HttpPost]
        public int Post([FromBody] AuthData auth_data)
        {
            int int_token = Program.Sessions.registration(auth_data);
            return int_token;
        }
    }
}
