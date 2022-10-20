﻿using Contact.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService ContactService) { contactService = ContactService; }

        [HttpGet]
        public Models.ContactModels.Contact Get() { return contactService.GetContact(); }

        [HttpGet("{id}")]
        public Models.ContactModels.Contact GetContactById(Guid Id) { return contactService.GetContactById(Id); }
    }
}
