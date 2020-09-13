using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancistoCloneWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinancistoCloneWeb.Controllers
{
    public class AccountController : Controller
    {
        private FinancistoContext _context;

        public AccountController(FinancistoContext context) {

            this._context = context;

        }

        [HttpGet]

        public ViewResult Index()
        {

            ViewBag.Accounts = _context.Acounts.ToList();
            //ViewBag.Accounts = GetDatos();
            return View("Index");
        }
        

        [HttpGet]
        public ViewResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public RedirectToActionResult Create(Account account)
        {               
            //var account = new Account { Name = Name, Type = Type, Currency = Currency, Ammount = Ammount };
            _context.Acounts.Add(account);
             _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
