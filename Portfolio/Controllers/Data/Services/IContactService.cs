using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers.Data.Services
{
    public interface IContactService
    {
        Contact GetById(int id);

        Task AddAsync(Contact contact);
    }
}
