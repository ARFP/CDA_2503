using _01_Api_Rest.Models;
using _01_Api_Rest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01_Api_Rest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchatController : ControllerBase
    {
        private readonly AchatService _achatService;

        public AchatController(AchatService achatService) =>
            _achatService = achatService;

        [HttpGet]
        public async Task<List<Achat>> Get() =>
            await _achatService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Achat>> Get(string id)
        {
            var achat = await _achatService.GetAsync(id);

            if (achat is null)
            {
                return NotFound();
            }

            return achat;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Achat newAchat)
        {
            await _achatService.CreateAsync(newAchat);

            return CreatedAtAction(nameof(Get), new { id = newAchat.Id }, newAchat);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Achat updatedAchat)
        {
            var achat = await _achatService.GetAsync(id);

            if (achat is null)
            {
                return NotFound();
            }

            updatedAchat.Id = achat.Id;

            await _achatService.UpdateAsync(id, updatedAchat);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var achat = await _achatService.GetAsync(id);

            if (achat is null)
            {
                return NotFound();
            }

            await _achatService.RemoveAsync(id);

            return NoContent();
        }
    }
}
