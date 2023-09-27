using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWebbansim.Controllers
{
    [Route("api")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet("about")]
        public IActionResult Get()
        {
            var str = "vai that chu";
            return Ok(str);
        }
    }
}
