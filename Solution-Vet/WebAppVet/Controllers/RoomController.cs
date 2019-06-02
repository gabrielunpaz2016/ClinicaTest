using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppVet.Data;

namespace WebAppVet.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        private ClinicaDBContext db = new ClinicaDBContext();
        public ActionResult Index()
        {
            var rooms = db.Rooms.ToList();
            return View(rooms);
        }
    }
}