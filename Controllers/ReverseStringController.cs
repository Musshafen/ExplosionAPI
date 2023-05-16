using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase

    {
        [HttpGet]
        public string Solution(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            var newString = new string(charArray);
            return $"Here is your string reversed: {newString}";
        }
    }
}
