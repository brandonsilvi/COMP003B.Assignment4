using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers;

public class ReservationController : Controller
{
    //Get for reservation, booking, for campsite code
    [HttpGet("reservation/book/{campsiteCode}")]
    public IActionResult BookWithCode(string campsiteCode)
    {
        var model = new Reservation
        {
            CampsiteCode = campsiteCode
        };
        return View("Book", model);
    }
    //Get reservation/book
    [HttpGet("reservation/book")]
    public IActionResult Book()
    {
        return View("Book", new Reservation());
    }
    //Post reservation/book
    [HttpPost("reservation/book")]
    public IActionResult book(Reservation model)
    {
        if (!ModelState.IsValid)
        {
            return View("Book", model);
        }

        return RedirectToAction("Confirmation", model);
    }
    //Get reserv confirm
    [HttpGet("reservation/confirmation")]
    public IActionResult Confirmation(Reservation model)
    {
        return View(model);
    }
}