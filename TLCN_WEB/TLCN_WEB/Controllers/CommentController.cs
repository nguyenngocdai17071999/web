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
    public class CommentController : Controller
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
            FirebaseResponse response = client.Get("Comment");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<Comment>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<Comment>(((JProperty)item).Value.ToString()));
            }
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            try
            {
                AddCommentToFireBase(comment);
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
            FirebaseResponse response = client.Get("Comment");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            var list = new List<Comment>();
            foreach (var item in data)
            {
                list.Add(JsonConvert.DeserializeObject<Comment>(((JProperty)item).Value.ToString()));
            }
            return (list.Count + 1).ToString();
        }
        private void AddCommentToFireBase(Comment comment)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = comment;
           // PushResponse response = client.Push("Comment/", data);
            data.CommentID = GetID();
            SetResponse setResponse = client.Set("Comment/" + data.CommentID, data);
        }
        [HttpGet]
        public ActionResult Detail(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("Comment/" + id);
            Comment data = JsonConvert.DeserializeObject<Comment>(response.Body);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("Comment/" + id);
            Comment data = JsonConvert.DeserializeObject<Comment>(response.Body);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Comment comment)
        {
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = client.Set("Comment/" + comment.CommentID, comment);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Delete("Comment/" + id);
            return RedirectToAction("Index");
        }
    }
}
