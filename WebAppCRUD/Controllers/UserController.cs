using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCRUD.Models;

namespace WebAppCRUD.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Random()
        {
            var user = new User() { UserID = 1346099 };
            return View(user);
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }
    }
}