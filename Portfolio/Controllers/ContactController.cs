using Microsoft.AspNetCore.Mvc;
using Portfolio.Controllers.Data.Services;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCar.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Contact([Bind("FullName, Email, Message")] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            //await _contactService.AddAsync(contact);
            ViewBag.Message = "Send Successfully";
            int id = contact.Id;
            return RedirectToAction("Details", new { id = id });
        }
        //public async Task<IActionResult> Index()
        //{
        //    var data = await _service.GetAllAsync();
        //    return View(data);
        //}

        //public async Task<IActionResult> Delete(int id)
        //{
        //    var contactDetails = await _service.GetByIdAsync(id);

        //    if (contactDetails == null) return View("NotFound");
        //    return View(contactDetails);
        //}

    }
}
