
using System.Web.Mvc;
using System.Web.Security;

using MvcProject.Models;
using DAL.Repositories;


namespace MvcProject.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UnitOfWork unintOfWork;


        public AccountController()
        {
            unintOfWork = new UnitOfWork();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()  
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var membershipUser = Membership.CreateUser(model.UserName, model.Password);

                if (membershipUser != null)
                {
                    var userEnitity = unintOfWork.Users.GetByLogin(model.UserName);
               
                    unintOfWork.Users.Update(userEnitity);

                    FormsAuthentication.SetAuthCookie(model.UserName, false);

                    

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Error registration.");
                }
            }
            return View(model);
        }
    }
}
