using Contact.Infrastructure;

namespace Contact.Services;

public class ContactService : IContactService
{
    public Models.ContactModels.Contact GetContact()
    { return new Models.ContactModels.Contact() { Id = Guid.NewGuid(), FirstName = "Zor", LastName = "Max" }; }

    public Models.ContactModels.Contact GetContactById(Guid Id)
    { return new Models.ContactModels.Contact() { Id = Id, FirstName = "Zor", LastName = "Max" }; }
}
