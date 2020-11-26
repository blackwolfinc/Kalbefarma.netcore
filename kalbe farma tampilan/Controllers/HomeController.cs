using kalbe_farma_tampilan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using kalbe_farma_tampilan.ViewsModels;
using System.Text;

namespace kalbe_farma_tampilan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tb_admin user)
        {
            using (var client = new HttpClient())
            {
                if (ModelState.IsValid)
                {
                    client.BaseAddress = new Uri("http://localhost:55748/api/Login");

                    var json = JsonConvert.SerializeObject(user);
                    HttpContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    var postTask = client.PostAsync("http://localhost:55748/api/Login/UserLogin", content);

                    postTask.Wait();


                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("HomePage", "Home");
                    }
                  
                    

                }
                return RedirectToAction("Index", "Home");
            }
            
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Login() {
            return View();
            }

        public ActionResult OpRiskStat()
        {
            return View();
        }


        public ActionResult Home()
        {
            return View();
        }

        HttpClient httpClient = new HttpClient();
        tb_document doc = new tb_document();
        List<tb_document> DocumentList = new List<tb_document>();
        public ActionResult HomePage()
        {
            

            return View();
        }

        [HttpGet]
        public ActionResult RiskOp()
        {
            using (var client = new HttpClient())
            {
                var viewModel = new DocumentViewModels();
                HttpResponseMessage response = httpClient.GetAsync("http://localhost:55748/api/document/GetAllDocument").GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    doc.ListDocuments = JsonConvert.DeserializeObject<IList<tb_document>>(result).ToList();

                    viewModel = new DocumentViewModels
                    {
                        DocumentList = doc.ListDocuments
                    };

                    if (viewModel == null)
                    {
                        return View(viewModel);
                    }



                }
                return View(viewModel);
            }
          
        }

        [HttpPost]
        public ActionResult RiskOp(tb_document doc)
        {
            var viewModels = new DocumentViewModels();

            viewModels = new DocumentViewModels
            {
                tb_document = doc
            };

            using (var client = new HttpClient())
            {
                if (ModelState.IsValid)
                {
                    client.BaseAddress = new Uri("http://localhost:55748/");
                    var postTask = client.PostAsJsonAsync("http://localhost:55748/api/document/AddNewDocument", doc);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("RiskOP", "Home");
                    }

                    return View(viewModels);
                }
            }
            return RedirectToAction("RiskOP", "Home");
        }

    }


}
