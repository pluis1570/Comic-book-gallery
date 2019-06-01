using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            { Content = "Hello from the ComicBooks Controller!" };
           // return "Hello from the ComicBooks Controller!";
        }
    }
}