using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers;

public class CampsiteController : Controller
{
    //list of sites for database
    private static List<Campsite> _campsites = new List<Campsite>
    {
        new Campsite
        {
            Id = 1, Name = "Pinecrest Lake", Location = "Yosemite Valley, CA", MaxOccupancy = 8, PricePerNight = 35.00m
        },
        new Campsite
            { Id = 2, Name = "Burney Falls", Location = "Burney, CA", MaxOccupancy = 6, PricePerNight = 55.00m },
        new Campsite
            { Id = 3, Name = "Pfieffer Park", Location = "Big Sur, CA", MaxOccupancy = 16, PricePerNight = 80.00m },
        new Campsite
        {
            Id = 4, Name = "Redwood Grove", Location = "Sequoia National Park, CA", MaxOccupancy = 10,
            PricePerNight = 100.00m
        },
        new Campsite
        {
            Id = 5, Name = "Lakeside Retreat", Location = "Lake Tahoe, CA", MaxOccupancy = 12, PricePerNight = 75.00m
        }
    };
    
    //get /campsite
    public IActionResult Index()
    {
        return View(_campsites);
    }
    //get campsite detail
    public IActionResult Details(int id)
    {
        var campsite = _campsites.FirstOrDefault(c => c.Id == id);
        if (campsite = null)
        {
            return NotFound();
        }

        return View(campsite);
    }
    //get campsite booking
    public IActionResult Book(int id)
    {
        var campsite = _campsites.FirstOrDefault(c => c.Id == id);
        if (campsite == null)
        {
            return NotFound();
        }

        return RedirectToAction("BookWithCode", "Reservation", new { campsiteCode = campsite.Name });
    }
    
}