using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milk.Api.Models;

namespace Milk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilksController : ControllerBase
    {
        private IMilkRepository _repo;

        public MilksController(IMilkRepository repo) => _repo = repo;

        [HttpGet]
        public IActionResult GetMilks()
        {
            var result = _repo.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetMilk(string id)
        {
            var result = _repo.GetOneById(id);

            if (result == null) 
            { 
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddMilk(MilkRequest add)
        {
            var result = _repo.Add(add.Name, add.Type, add.Storage);

            return CreatedAtAction(nameof(GetMilk), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMilk(string id, MilkRequest update)
        {
            if (_repo.GetOneById(id) == null) 
            {
                return NotFound();
            }

            var result = _repo.Update(id, update.Name, update.Type, update.Storage);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMilk(string id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}
