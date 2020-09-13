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
        private FinancistoContext context;

        public AccountController(FinancistoContext context) {

            this.context = context;

        }

        public ViewResult Index()
        {

            ViewBag.Accounts = context.Acounts.ToList();
            //ViewBag.Accounts = GetDatos();
            return View("Index");
        }


        public string Save(string Name, string Type, string Currency, decimal Amount )
        {
            var account = new Account { Name = Name, Type = Type, Currency = Currency, Ammount = Amount };
            context.Acounts.Add(account);
            context.SaveChanges();
            return Type + " " + Name + " "+ Currency + " " + Amount ;
        } 
        
        public ViewResult Create()
        {
            return View("Create");
        }
        
   
        

    }
}
