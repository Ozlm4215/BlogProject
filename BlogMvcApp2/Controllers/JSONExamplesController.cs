using BlogMvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp2.Controllers
{
    public class JSONExamplesController : Controller
    {
        // GET: JSONExamples 

        [HttpGet]
        public ActionResult Posts()
        {

            return View(GetPosts());
        }

        public ActionResult PostsGet()
        {
            return View();
        }


        [HttpGet]
        public JsonResult PostsGetjson()
        {
            List<Post> posts = new List<Post>();
            using (var client = new HttpClient())
            {
                var content = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
                posts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(content);
            }
            return Json(posts, JsonRequestBehavior.AllowGet);
        }



        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();
            using (var client = new HttpClient())
            {
                var content = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
                posts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(content);
            }
            return posts;
        }

        public ActionResult NewPosts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewPosts(Post post)
        {
            using (var client = new HttpClient())
            {
                //Auth Token Gönderme
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + "dssddsdadadasdasdad");
                // mmmmmm
                // Auth Basic
                //var authenticationBytes = Encoding.ASCII.GetBytes("YourUsername:YourPassword");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                //Convert.ToBase64String(authenticationBytes));


                var json = Newtonsoft.Json.JsonConvert.SerializeObject(post);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var content = client.PostAsync("https://jsonplaceholder.typicode.com/posts", stringContent).Result;

                var reads = content.Content.ReadAsStringAsync().Result;
            }
            return View();


        }




        [HttpPost]
        public JsonResult NewPostsjson(Post post)
        {
            using (var client = new HttpClient())
            {
                //Auth Token Gönderme
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + "dssddsdadadasdasdad");

                // Auth Basic
                //var authenticationBytes = Encoding.ASCII.GetBytes("YourUsername:YourPassword");
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                //Convert.ToBase64String(authenticationBytes));


                var json = Newtonsoft.Json.JsonConvert.SerializeObject(post);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var content = client.PostAsync("https://jsonplaceholder.typicode.com/posts", stringContent).Result;

                var reads = content.Content.ReadAsStringAsync().Result;
            }
            return Json(post, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Update(int Id)
        {
            var gelen = GetPosts().Where(p => p.id == Id).FirstOrDefault();
            return View(gelen);
        }

        [HttpPost]

        public ActionResult Update(Post post)
        {
            using (var client = new HttpClient())
            {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(post);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                var content = client.PutAsync("https://jsonplaceholder.typicode.com/posts/" + post.id, stringContent).Result;

                var reads = content.Content.ReadAsStringAsync().Result;
            }


            return View();


        }


        // Auth Basic --
        //var authenticationBytes = Encoding.ASCII.GetBytes("YourUsername:YourPassword");
        //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
        //Convert.ToBase64String(authenticationBytes));

    }
}