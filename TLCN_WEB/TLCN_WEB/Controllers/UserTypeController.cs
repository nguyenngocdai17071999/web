using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TLCN_WEB.Models;

namespace TLCN_WEB.Controllers
{
    public class UserTypeController : Controller
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "0ypBJAvuHDxyKu9sDI6xVtKpI6kkp9QEFqHS92dk",
            BasePath = "https://tlcn-1a9cf.firebaseio.com/"
        };
        IFirebaseClient client;
        public IActionResult Index()
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("UserType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<UserType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<UserType>(((JProperty)item).Value.ToString()));
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(UserType userType)
        {
            try
            {
                AddToFireBase(userType);
                ModelState.AddModelError(string.Empty, "Added Successfully");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            return View();
        }
        private string GetID()
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("UserType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<UserType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<UserType>(((JProperty)item).Value.ToString()));
            }
            return (list.Count + 1).ToString();
        }
        private void AddToFireBase(UserType usertype)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = usertype;
            //PushResponse response = client.Push("UserType/", data);
            data.UserTypeID = GetID();
            SetResponse setResponse = client.Set("UserType/" + data.UserTypeID, data);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("UserType/" + id);
            UserType data = JsonConvert.DeserializeObject<UserType>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("UserType/" + id);
            UserType data = JsonConvert.DeserializeObject<UserType>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(UserType userType)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("UserType/" + userType.UserTypeID, userType);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("UserType/" + id);
            return RedirectToAction("Index");
        }
    }
}
