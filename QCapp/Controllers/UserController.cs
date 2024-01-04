﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QCapp.Models.SchemaViewModel;

namespace QCapp.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            var listUserViewModel = new List<UserViewModel>();
            listUserViewModel.Add(
                    new UserViewModel()
                    {
                        UserId = 1,
                        FirstName = "Vijaya",
                        MiddleName = "Kumar",
                        LastName = "Nv",
                        EmailAddress = "vijay.nv@mail.com",
                        CompanyName = "ABC Inc.",
                        ContactNumber = "0123456789",
                        AccessLevelName = "Manager",
                        ProcessName = "Call Monitoring",
                        ActiveStatus = true
                    }
                );
            listUserViewModel.Add(
                    new UserViewModel()
                    {
                        UserId = 2,
                        FirstName = "Krishna",
                        MiddleName = "Kumar",
                        LastName = "",
                        EmailAddress = "krishna@mail.com",
                        CompanyName = "ABC Inc.",
                        ContactNumber = "0123456788",
                        AccessLevelName = "Admin",
                        ProcessName = "Call Monitoring",
                        ActiveStatus = true
                    }
                );

            return View(listUserViewModel);
        }

        public ActionResult Create()
        {
            var objUserViewModel = new UserViewModel();
            return View(objUserViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
