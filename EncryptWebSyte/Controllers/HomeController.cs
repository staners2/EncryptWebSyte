using EncryptWebSyte.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptWebSyte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Index(PropertyEncrypt Prop)
        {
            if (ModelState.IsValid)
            {
                var EncryptObject = new PropertyEncrypt(Prop.InputText, Prop.InputEncryptKey);
                EncryptObject.StartEncrypt();
                ViewBag.InputEncryptKey = EncryptObject.InputEncryptKey;
                ViewBag.InputEncryptText = EncryptObject.InputText;
                ViewBag.DescryptKey = EncryptObject.DescryptKey;
                ViewBag.ResultEncryptText = EncryptObject.ResultText;
                return View();
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(PropertyDescrypt Prop)
        {
            if (ModelState.IsValid)
            {
                var DescryptObject = new PropertyDescrypt(Prop.InputText, Prop.InputDescryptKey);
                DescryptObject.StartDescrypt();
                ViewBag.InputDescryptKey = DescryptObject.InputDescryptKey;
                ViewBag.InputDescryptText = DescryptObject.InputText;
                ViewBag.EncryptKey = DescryptObject.EncryptKey;
                ViewBag.ResultDescryptText = DescryptObject.ResultText;
                return View();
            }
            
            return View();
        }*/
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
