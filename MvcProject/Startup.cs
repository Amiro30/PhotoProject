﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProject.Startup))]
namespace MvcProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
