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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string Accum(string str)
        {

            var sentenceList = new List<string>();


            for (var letter = 0; letter < str.Count(); letter++)
            {
                sentenceList.Add(str[letter].ToString().ToUpper());
            }


            for (var count = 1; count < sentenceList.Count(); count++)
            {
                for (var letterCount = 0; letterCount < count; letterCount++)
                {
                    string newLetters = sentenceList[count];

                    if (letterCount > 0)
                    {
                        sentenceList[count] = newLetters + newLetters[newLetters.Count() - 1].ToString();
                    }

                    else if (letterCount == 0)
                    {
                        sentenceList[count] = sentenceList[count] + sentenceList[count].ToLower();
                    }
                }
            }

            var letterString = String.Join("-", sentenceList);

            return $"Here is the new string mumbled: {letterString}";
        }
    }
}
