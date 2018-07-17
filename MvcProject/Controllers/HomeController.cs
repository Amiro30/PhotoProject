using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Interfaces;
using AutoMapper;
using DAL.Entities;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPhotoRepo _photos;

        public HomeController(IPhotoRepo photos)
        {
            _photos = photos;
        }
        public ActionResult Index()
        {
            var model = Mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoModel>>(_photos.GetAll());
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}