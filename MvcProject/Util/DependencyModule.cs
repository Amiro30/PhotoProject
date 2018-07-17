using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.Interfaces;
using Ninject.Modules;

namespace MvcProject.Util
{
    public class DependencyModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<IUserService>();
        }
    }
}