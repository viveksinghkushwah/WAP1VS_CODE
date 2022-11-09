
using Microsoft.AspNetCore.Mvc;
using WAP1VS_CODE.Models;

namespace WAP1VS_CODE.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> Characters = new List<Character>{
            new Character(),
            new Character{Id=1,Name="Vivek"}
        };


        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(Characters);
        }
        [HttpGet]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(Characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            Characters.Add(newCharacter);
            return Ok(Characters);
        }
    }
}                                                                                                                                                                                                                                                                                        