using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _events = new Event[] {
            new Event(){
                    EventId = 1,
                    Theme = "Angular 11 and .NET 5",
                    Localization = "Berlin",
                    Lot = "1st lot",
                    QtyAttendees = 250,
                    EventDate = DateTime.Now.AddDays(2).ToString("dd.MM.yyy"),
                    ImageUrl = "Foto.jpg"
                },
                new Event(){
                    EventId = 2,
                    Theme = "Swift 5",
                    Localization = "Berlin",
                    Lot = "2nd lot",
                    QtyAttendees = 500,
                    EventDate = DateTime.Now.AddDays(4).ToString("dd.MM.yyy"),
                    ImageUrl = "Foto2.jpg"
                }
        };
        public EventController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _events.Where(eventItem => eventItem.EventId == id);
        }
    }
}