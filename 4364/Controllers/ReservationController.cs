using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4364.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _4364.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository _respository;

        public ReservationController(IReservationRepository respository)
        {
            _respository = respository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CreateReservationModel model)
        {
            var result = _respository.CreateReservation(model);
            if (model.Confirmation == true)
                return RedirectToAction("Confirmation");
            else
                return null;
        }
        public IActionResult Confirmation()
        {
            ViewBag.ConfirmationMessage = "Your reservation has been confirmed.";
            return View();
        }
    }
}
