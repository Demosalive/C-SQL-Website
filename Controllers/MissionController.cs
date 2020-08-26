using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supers.Models;

namespace Supers.Controllers
{
    public class MissionController : Controller
    {
        private readonly SupersDbContext _context;

        public MissionController(SupersDbContext context)
        {
            _context = context;
        }

        public IActionResult Mission()
        {
            List<Mission> mission = _context.Mission.ToList();
            return View(mission);
        }

        [HttpGet]//this method is simply displaying in fo in the view
        public IActionResult AddMission()
        {
            return View();
        }

        [HttpPost]//this method is recieveing information from the view(in this case, a Super object)
        public IActionResult AddMission(Mission newMission)
        {
            if (ModelState.IsValid)
            {
                _context.Mission.Add(newMission);
                _context.SaveChanges();//dont forget this  saves it back to sql
            }

            return RedirectToAction("Mission");//RedirectTo Action goes to method index
        }

        public IActionResult DeleteMission(int id)
        {
            //find the super we want to delete from the database
            //Find() will bring back an entire Super via its primary key
            var foundMission = _context.Mission.Find(id);
            if (foundMission != null)
            {
                _context.Mission.Remove(foundMission);
                _context.SaveChanges();
            }

            return RedirectToAction("Mission");
        }
    }
}
