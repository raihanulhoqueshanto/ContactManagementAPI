using ContactManagementAPI.Application.Common.Models;
using ContactManagementAPI.Application.Requests.ContactManagement.Contacts.Queries;
using ContactManagementAPI.Domain.Entities.ContactManagement.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementAPI.Application.Requests.ContactManagement.Contacts
{
    public interface IContactService : IDisposable
    {
        Task<Result> CreateOrUpdateContact(Contact request);
        Task<List<Contact>> GetContactList(GetContactList request);
        Task<Result> DeleteContact(DeleteContact request);
    }
}
