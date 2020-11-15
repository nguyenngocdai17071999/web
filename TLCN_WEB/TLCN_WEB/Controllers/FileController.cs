using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Storage;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TLCN_WEB.Models;


namespace TLCN_WEB.Controllers
{
    public class FileController : Controller
    {
        private static string ApiKey = "AIzaSyDNRD7rcNybO5pVkC8POMiMhYYwmfreUVQ";
        private static string Bucket = "tlcn-1a9cf.appspot.com";
        private static string AuthEmail = "adfs@gmail.com";
        private static string AuthPassword = "adfs12";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Department department, IFormFile file)
        {
            FileStream stream;
            if(file.ContentType!=null)
            {
                //string path = Path.Combine(Microsoft.AspNetCore.Server.)
            }    
            return View();
        }

        public async void Upload(FileStream stream,string filename)
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);


            var cancellation = new CancellationTokenSource();
            var task = new FirebaseStorage(
                Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child("images")
                .Child(filename)
                .PutAsync(stream, cancellation.Token);

            try
            {
                string link = await task;
            }
            catch(Exception ex) {
                Console.WriteLine("Exception was know: {0}", ex);
            }

        }
    }
}
