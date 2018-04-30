using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Expedia.Models;
using Expedia.Service;

namespace Expedia.Controllers
{
    public class Hotel : Controller
    {
        private readonly IServices _service;
        public Hotel(IServices service)
        {
            _service = service;
        }


        public IActionResult HotelPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ViewResult(RequestHotel request)
        {
            var availableHotels = _service.AvailableHotels(request).Result;
            
            return View( availableHotels);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
