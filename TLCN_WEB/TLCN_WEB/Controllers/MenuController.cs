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
    public class MenuController : Controller
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
            FirebaseResponse response = client.Get("Menu");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<Menu>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<Menu>(((JProperty)item).Value.ToString()));
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            try
            {
                AddToFireBase(menu);
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
            FirebaseResponse response = client.Get("Menu");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<Menu>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<Menu>(((JProperty)item).Value.ToString()));
            }
            return (list.Count + 1).ToString();
        }
        private void AddToFireBase(Menu menu)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = menu;
            //PushResponse response = client.Push("Menu/", data);
            data.MenuID = GetID();
            SetResponse setResponse = client.Set("Menu/" + data.MenuID, data);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("Menu/" + id);
            Menu data = JsonConvert.DeserializeObject<Menu>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("Menu/" + id);
            Menu data = JsonConvert.DeserializeObject<Menu>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Menu menu)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("Menu/" + menu.MenuID, menu);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("Menu/" + id);
            return RedirectToAction("Index");
        }
    }
}
