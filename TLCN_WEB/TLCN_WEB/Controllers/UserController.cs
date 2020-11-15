using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TLCN_WEB.Models;
using MimeKit;
using MailKit.Net.Smtp;

namespace TLCN_WEB.Controllers
{
    public class UserController : Controller
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0ypBJAvuHDxyKu9sDI6xVtKpI6kkp9QEFqHS92dk",
            BasePath = "https://tlcn-1a9cf.firebaseio.com/"
        };
        IFirebaseClient client;
        private static string key = "TLCN";
        public IActionResult Index()
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("User");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<User>();
            //danh sách tìm kiếm
            //var list2 = new List<User>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<User>(((JProperty)item).Value.ToString()));
                

            }
            //Hàm tìm kiếm 
            //foreach (var item in list)
            //{
            //    if(item.UserName.Contains("hai ban 23"))
            //    {
            //        list2.Add(item);
            //    }
            //}


            ////Gửi email
            var messenge = new MimeMessage();
            messenge.From.Add(new MailboxAddress("Test Project", "nguyenngocdai17071999@gmail.com"));
            messenge.To.Add(new MailboxAddress("naren", "tanphan263@gmail.com"));
            messenge.Subject = "hello";
            messenge.Body = new TextPart("plain")
            {
                Text = "hello pro"
            
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("nguyenngocdai17071999@gmail.com", "conyeume");
                client.Send(messenge);
                client.Disconnect(true);
            }

            //var messenge = new MailMessage();
            //messenge.From.Add(new MaiB)

            //string to = "nguyenngocdai17071999@gmail.com";
            //string subject = "a";
            //string body = "a";

            //MailMessage mv = new MailMessage();
            //mv.To.Add(to);
            //mv.Subject = subject;
            //mv.Body = body;
            //mv.From = new MailAddress("nguyenngocdai17071999@gmail.com");
            //mv.IsBodyHtml = false;
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.Port = 9050;
            //smtp.UseDefaultCredentials = false;
            //smtp.EnableSsl = true;
            //smtp.Credentials = new System.Net.NetworkCredential("nguyenngocdai17071999@gmail.com", "conyeume");
            //smtp.Send(mv);




            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            try
            {
                AddToFireBase(user);
                ModelState.AddModelError(string.Empty, "Added Successfully");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            //Gửi email
            //string to = "nguyenngocdai17071999@gmail.com";
            //string subject = "a";
            //string body = "a";

            //MailMessage mv = new MailMessage();
            //mv.To.Add(to);
            //mv.Subject = subject;
            //mv.Body = body;
            //mv.From = new MailAddress("nguyenngocdai17071999@gmail.com");
            //mv.IsBodyHtml = false;
            //SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            //smtp.Port = 587;
            //smtp.UseDefaultCredentials = true;
            //smtp.EnableSsl = true;
            //smtp.Credentials = new System.Net.NetworkCredential("nguyenngocdai17071999@gmail.com", "conyeume");
            //smtp.Send(mv);

            return View();
        }
        private string GetID()
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("User");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<User>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<User>(((JProperty)item).Value.ToString()));
            }
            return (list.Count + 1).ToString();
        }
        private void AddToFireBase(User user)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = user;
          //  PushResponse response = client.Push("User/", data);
            data.UserID = GetID();
            data.Password = Encrypt(data.Password);
            SetResponse setResponse = client.Set("User/" + data.UserID, data);
        }

        public static string Encrypt(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("User/" + id);
            User data = JsonConvert.DeserializeObject<User>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("User/" + id);
            User data = JsonConvert.DeserializeObject<User>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("User/" + user.UserID, user);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("User/" + id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult LoginAccount()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginAccount(Login login)
        {
            try
            {
                // CheckAccount(login);

                client = new FireSharp.FirebaseClient(config);
                FirebaseResponse response = client.Get("User");
                dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
                var list = new List<User>();
                foreach (var item in data)
                {
                    list.Add(JsonConvert.DeserializeObject<User>(((JProperty)item).Value.ToString()));
                }
                foreach (var item in list)
                {
                    if (item.Email == login.Email && item.Password == Encrypt(login.Password))
                    {
                        ModelState.AddModelError(string.Empty, "thanh cong");
                        break;
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "that bai");
                    }
                }
                //ModelState.AddModelError(string.Empty, "Added Successfully");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View();
        }

    }
}
