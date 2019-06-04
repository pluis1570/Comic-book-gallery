using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookrepository = null;

        public ComicBooksController()
        {
            _comicBookrepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBook = _comicBookrepository.GetComicBooks();
            return View(comicBook);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookrepository.GetComicBook((int)id);
            return View(comicBook);
        }
                       
    }
}
