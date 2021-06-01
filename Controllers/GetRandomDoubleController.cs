using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class GetRandomDoubleController : ControllerBase
    {
        
        
        [HttpGet]
        public string Get(string minMax)
        {
            
            var MinMax =  JsonSerializer.Deserialize<MinMax>(minMax);
            RandomDouble rnd = new RandomDouble(MinMax);
           

            return JsonSerializer.Serialize<RandomDouble>(rnd);
        }
    }
}
