using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectBookStore.Data;
using ProjectBookStore.Models;

namespace ProjectBookStore.Controllers
{
    public class UserAccountsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UserAccountsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserAccount users)
        {

            var result = _context.users.Where(u => u.email == users.email && u.pass == users.pass).SingleOrDefault();
            if (result != null)
            {
                if (result.role == 1)
                {
                  //  ViewBag.msg1 = "Admin";
                    return RedirectToAction("Index","Books");
                }
                else if (result.role == 2)
                {
                    //ViewBag.msg2 = "User";
                    return RedirectToAction("Index","UserAccounts");
                }
            }
            // else
            // {
            //ViewBag.popmessage = "<script> alert ( 'login successfull...' )</script>";
            return View();
            // }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserAccount users)
        {
            try
            {
                users.role = 1;
                _context.Add(users);
                _context.SaveChanges();
               
            }
            
            catch (Exception ex)
            {

            }

            return RedirectToAction("Login", "UserAccount");


        }
    }
}