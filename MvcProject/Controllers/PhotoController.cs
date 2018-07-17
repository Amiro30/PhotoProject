using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Interfaces;
using DAL.Entities;
using MvcProject.Models;
using AutoMapper;

namespace MvcProject.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoRepo _photos;

        public PhotoController(IPhotoRepo photos)
        {
            _photos = photos;
        }

        public ActionResult Index()
        {
            return View("Index", _photos.GetAll());
        }
        // GET: /Photo/Create

        public ActionResult Create()
        {
            Photo newPhoto = new Photo();

            var model = Mapper.Map<Photo, PhotoModel>(newPhoto);
            
            model.CreatedDate = DateTime.Today;
            
            return View(model);
        }
        // POST: /Photo/Create
     
        [HttpPost]
        public ActionResult Create(Photo photo, HttpPostedFileBase image)
        {
            var model = Mapper.Map<Photo, PhotoModel>(photo);
            model.CreatedDate = DateTime.Today;

            if (ModelState.IsValid)
            {
                //Is there a photo? If so save it
                if (image != null)
                {
                    model.ImageMimeType = image.ContentType;
                    model.PhotoFile = new byte[image.ContentLength];
                    image.InputStream.Read(model.PhotoFile, 0, image.ContentLength);
                }

                //Add the photo to the database and save it
                _photos.Create(photo);

                return RedirectToAction("Index");
            }

            return View(photo);
        }
    }
}