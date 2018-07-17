using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;



namespace MvcProject
{
    public class Registrations: NinjectModule
    {
        public override void Load()
        {
            Bind<IPhotoRepo>().To<PhotoRepository>();
        }
    }
}