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
    public class DishTypeController : Controller
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
            FirebaseResponse response = client.Get("DishType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<DishType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<DishType>(((JProperty)item).Value.ToString()));
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(DishType dishtype)
        {
            try
            {
                AddToFireBase(dishtype);
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
            FirebaseResponse response = client.Get("DishType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<DishType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<DishType>(((JProperty)item).Value.ToString()));
            }
            return (list.Count + 1).ToString();
        }
        private void AddToFireBase(DishType dishType)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = dishType;
           // PushResponse response = client.Push("DishType/", data);
            data.DishType_ID = GetID();
            SetResponse setResponse = client.Set("DishType/" + data.DishType_ID, data);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("DishType/" + id);
            DishType data = JsonConvert.DeserializeObject<DishType>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("DishType/" + id);
            DishType data = JsonConvert.DeserializeObject<DishType>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(DishType dishType)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("DishType/" + dishType.DishType_ID, dishType);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("DishType/" + id);
            return RedirectToAction("Index");
        }
    }
}
