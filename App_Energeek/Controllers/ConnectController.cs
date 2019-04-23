using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_Energeek.Models;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App_Energeek.Controllers
{
    public class ConnectController : Controller

    {
        protected UserService _service;

        public ConnectController(UserService service)
        {
            _service = service;
        }

        // EmployeeDBEntities Db = new EmployeeDBEntities();

        // GET: /Login/
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            string message = string.Empty;
            //message = JsonConvert.SerializeObject(user);

            if (_service.RegisterApi(user) == "ok"){
                message = "Compte créé";
            }
            else if (_service.RegisterApi(user) == "user exist")
            {
                message = "L'utilisateur existe déjà";
            }
            else
            {
                message = "Erreur lors de la création de compte";
            }

            ViewBag.Message = message;
            return View();
        }

        /*
        [HttpPost]

        public ActionResult Login(Login LoginVar)

        {



            var result1 = (from Users in Db.TblEmployees where emp.EmailId == LoginVar.UserName select emp.Password).FirstOrDefault();

            string DPassword = Decrypt(result1);

            // Db.TblEmployees.Where(m=>m.EmailId==LoginVar.UserName && m.Password==LoginVar.Password).FirstOrDefault()

            if (DPassword == LoginVar.Password)

            {

                return RedirectToAction("EmployeeDetails", "Employee", new { area = "Admin" });

            }

            else

            {

                ViewBag.Message = string.Format("UserName and Password is incorrect");

                return View();

            }



        }



        [NonAction]

        public string Decrypt(string cipherText)

        {

            if (cipherText != null)

            {

                string EncryptionKey = "MAKV2SPBNI99212";

                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                using (Aes encryptor = Aes.Create())

                {

                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                    encryptor.Key = pdb.GetBytes(32);

                    encryptor.IV = pdb.GetBytes(16);

                    using (MemoryStream ms = new MemoryStream())

                    {

                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))

                        {

                            cs.Write(cipherBytes, 0, cipherBytes.Length);

                            cs.Close();

                        }

                        cipherText = Encoding.Unicode.GetString(ms.ToArray());

                    }

                }

                return cipherText;

            }

            return null;

        }*/



    }
}
