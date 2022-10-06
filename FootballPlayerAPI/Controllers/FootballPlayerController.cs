using Microsoft.AspNetCore.Mvc;
using FootballPlayerAPI.Managers;
using FootballLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballPlayerAPI.Controllers
{

    [Route("api")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private FootballPlayerManager footballPlayerManager = new FootballPlayerManager();

        // GET: api/<FootballPlayerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(footballPlayerManager.getAll());
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(footballPlayerManager.get(id));
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public IActionResult Post([FromBody] FootballPlayer value)
        {
            return Ok(footballPlayerManager.add(value));
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] FootballPlayer value)
        {
            footballPlayerManager.update(value);
        }

        // DELETE api/<FootballPlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            footballPlayerManager.delete(id);
        }
    }
}
