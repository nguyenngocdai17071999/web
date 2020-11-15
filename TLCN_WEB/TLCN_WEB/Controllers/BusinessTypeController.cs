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
    public class BusinessTypeController : Controller
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
            FirebaseResponse response = client.Get("BusinessType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<BusinessType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<BusinessType>(((JProperty)item).Value.ToString()));
            }
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(BusinessType businessType)
        {
            try
            {
                AddBusinessTypeToFireBase(businessType);
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
            FirebaseResponse response = client.Get("BusinessType");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<BusinessType>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<BusinessType>(((JProperty)item).Value.ToString()));
            }
            return (list.Count+1).ToString();
        }
        private void AddBusinessTypeToFireBase(BusinessType businessType)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = businessType;
            //PushResponse response = client.Push("BusinessType/", data);
            data.BusinessTypeID = GetID();
            SetResponse setResponse = client.Set("BusinessType/" + data.BusinessTypeID, data);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("BusinessType/" + id);
            BusinessType data = JsonConvert.DeserializeObject<BusinessType>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("BusinessType/" + id);
            BusinessType data = JsonConvert.DeserializeObject<BusinessType>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(BusinessType businessType)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("BusinessType/" + businessType.BusinessTypeID, businessType);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("BusinessType/" + id);
            return RedirectToAction("Index");
        }
    }
}
