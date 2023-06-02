using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers.Services;
using WebApi.Models.DTO;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly ContactService _contactService;

		public ContactController(ContactService contactService)
		{
			_contactService = contactService;
		}
		public async Task<IActionResult> SendMessage(AddMessage newMessage)
		{
			if(!ModelState.IsValid) 
			return BadRequest(ModelState);

			var result = await _contactService.SendMessageAsync(newMessage);

			if(result == true)
			{
				return Ok(newMessage);
			}
			return StatusCode(500);
		}
	}
}
