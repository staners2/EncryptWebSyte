using EncryptWebSyte.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EncryptWebSyte.DataBase;
using Microsoft.EntityFrameworkCore;

namespace EncryptWebSyte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DataContext db { get; set; }

        public HomeController(ILogger<HomeController> logger, DataContext DataContext)
        {
            _logger = logger;
            db = DataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string TypeOperation, string InputText, string InputKey)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Заполните все поля!";
                return View();
            }
            if (TypeOperation == "Encrypt")
            {
                var EncryptObject = new PropertyEncrypt(InputText, InputKey);
                EncryptObject.StartEncrypt();
                ViewBag.InputEncryptKey = EncryptObject.InputEncryptKey;
                ViewBag.InputEncryptText = EncryptObject.InputText;
                ViewBag.DescryptKey = EncryptObject.DescryptKey;
                ViewBag.ResultEncryptText = EncryptObject.ResultText;

                db.Encrypts.Add(new Encrypt(InputText, EncryptObject.InputEncryptKey, EncryptObject.DescryptKey, EncryptObject.ResultText));
                db.SaveChanges();


                return View();
            }
            if (TypeOperation == "Descrypt")
            {
                var DescryptObject = new PropertyDescrypt(InputText, InputKey);
                DescryptObject.StartDescrypt();
                ViewBag.InputDescryptKey = DescryptObject.InputDescryptKey;
                ViewBag.InputDescryptText = DescryptObject.InputText;
                ViewBag.EncryptKey = DescryptObject.EncryptKey;
                ViewBag.ResultDescryptText = DescryptObject.ResultText;

                db.Descrypts.Add(new Descrypt(InputText, DescryptObject.InputDescryptKey, DescryptObject.EncryptKey, DescryptObject.ResultText));
                db.SaveChanges();

                return View();
            }
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
