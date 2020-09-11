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
            return Type + " " + Name + " "+ Currency + " " + Amount ;
        } 
        
        public ViewResult Create()
        {
            ViewBag.Accounts = GetDatos();
            return View("Create");
        }
        
   
        private List<Account> GetDatos() 
        {
            var data = new List<Account>();
            data.Add(new Account { 
                Type = "Efectivo",
                Name = "Billetera",
                Currency = "Soles",
                Ammount = 0,
            
            });
            
            data.Add(new Account { 
                Type = "Debito",
                Name = "BCP Tarjeta Debito",
                Currency = "Soles",
                Ammount = 1000,
            
            }); 

            data.Add(new Account { 
                Type = "Credito",
                Name = "BCP Tarjeta Credito",
                Currency = "Soles",
                Ammount = 1000,
            
            });

            return data;
        }

    }
}
