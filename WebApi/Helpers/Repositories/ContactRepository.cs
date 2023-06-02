using WebApi.Contexts;
using WebApi.Models.Entities;

namespace WebApi.Helpers.Repositories
{
	public class ContactRepository
	{
		private readonly DataContext _context;
		
		public ContactRepository(DataContext context)
		{
			_context = context;
		}
		public async Task<bool> SendMessageSync(ContactEntity newMessage)
		{
			try
			{
				_context.Contact.Add(newMessage);
				await _context.SaveChangesAsync();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
