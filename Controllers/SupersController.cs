using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supers.Models;

namespace Supers.Controllers
{
    public class SupersController : Controller
    {
        private readonly SupersDbContext _supersdb;
       
        public SupersController(SupersDbContext context)
        {
            _supersdb = context;
        }
       
        public IActionResult Supers()
        {
            List<Super> super = _supersdb.Super.ToList();
            return View(super);
        }

        [HttpGet]//this method is simply displaying in fo in the view
        public IActionResult AddSuper()
        {
            return View();
        }

        [HttpPost]//this method is recieveing information from the view(in this case, a Super object)
        public IActionResult AddSuper(Super newSuper)
        {
            if (ModelState.IsValid)
            {
                _supersdb.Super.Add(newSuper);
                _supersdb.SaveChanges();//dont forget this  saves it back to sql
            }

            return RedirectToAction("Index");//RedirectTo Action goes to method index
        }

        public IActionResult DeleteSuper(int id)
        {
            //find the super we want to delete from the database
            //Find() will bring back an entire Super via its primary key
            var foundSuper = _supersdb.Super.Find(id);
            if(foundSuper != null)
            {
                _supersdb.Super.Remove(foundSuper);
                _supersdb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
