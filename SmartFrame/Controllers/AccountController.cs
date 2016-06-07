using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SmartFrame.AuthorizationServiceReference;
using SmartFrame.Models.Account;
using SmartFrame.Utils.Auth;

namespace SmartFrame.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private IAuthentication authentication;

        public AccountController(IAuthentication auth)
        {
            this.authentication = auth;
            Mapper.CreateMap<UserContract, LoginViewModel>().ReverseMap();
            Mapper.CreateMap<UserContract, RegisterViewModel>().ReverseMap();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = authentication.Login(model.UserName, model.Password);
                if (user != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(model);
        }

        public ActionResult Logout()
        {
            authentication.LogOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = authentication.CreateUser(Mapper.Map<UserContract>(model));
                if (user != null)
                {
                    return RedirectToAction("GetAll", "Game");
                }
            }

            return View(model);
        }
    }
}