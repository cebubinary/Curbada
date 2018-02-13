using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebSockets;
using Curbada.Models;
using Newtonsoft.Json;

namespace Curbada.Controllers
{
    public class ReservationController : Controller
    {
        public ActionResult Reservation()
        {
            ViewBag.Message = "Reservation page.";

            return View();
        }

        public ActionResult BookingDetails()
        {
            ViewBag.Message = "Booking details page.";

            return View();
        }

        public ActionResult RoomSetup()
        {
            ViewBag.Message = "Room setup page.";

            return View();
        }

        [HttpGet]
        public JsonResult Search(ReservationModel model)
        {
            var result = new List<RoomModel>
            {
                new RoomModel { Name = "Deluxe", Capacity = "6", Rate = "2500", Notes = "This is a noted"},
                new RoomModel { Name = "Economy", Capacity = "2", Rate = "1500", Notes = "This is a noted"},
                new RoomModel { Name = "Executive", Capacity = "4", Rate = "2000", Notes = "This is a noted"}
            };

            return Json(new { IsSuccess = true, Data = JsonConvert.SerializeObject(result) }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Book(ReservationModel model)
        {
            return Json(new { IsSuccess = true });
        }
    }
}