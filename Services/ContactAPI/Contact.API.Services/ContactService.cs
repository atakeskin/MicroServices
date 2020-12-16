using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactByID(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName="Atalay",
                LastName="Keskin"
            };
        }
    }
}
