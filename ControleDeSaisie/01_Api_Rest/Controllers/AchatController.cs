using _01_Api_Rest.Models;
using _01_Api_Rest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Model.Strings;

namespace _01_Api_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchatController : ControllerBase
    {
        private readonly AchatService _achatService;

        public AchatController(AchatService achatService)
        {
            _achatService = achatService;
        }

        [HttpGet]
        public async Task<List<Achat>> Get()
        {
            return await _achatService.GetAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Achat>> Get(string _id)
        {
            Achat? result = await _achatService.GetAsync(_id);

            if(result is null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Achat newAchat)
        {
            await _achatService.CreateAsync(newAchat);

            return CreatedAtAction(nameof(Get), new { id = newAchat.Id }, newAchat);
        }

       
    }
}
