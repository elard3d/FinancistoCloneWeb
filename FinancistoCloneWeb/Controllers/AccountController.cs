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
            
            return View("Index");
        }
        

        [HttpGet]
        public ViewResult Create()//GET
        {
            return View("Create");
        }


        [HttpPost]
        public ActionResult Create(Account account)//POST
        {
            //if (account.Name == null || account.Name == "") 

            //    ModelState.AddModelError("Name", "El campo Nombre es obligatorio");

                if (ModelState.IsValid) {

                    _context.Acounts.Add(account);
                    //_context.SaveChanges();

                    return RedirectToAction("Index");

                }

                return View("Create");
            
        }


    }
}
