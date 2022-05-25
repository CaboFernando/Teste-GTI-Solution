using SiteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SiteMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            IEnumerable<ClienteViewModel> clientes = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/");

                var responseTask = client.GetAsync("clientes");
                responseTask.Wait();
                var result = responseTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ClienteViewModel>>();
                    readTask.Wait();

                    clientes = readTask.Result;
                }
                else
                {
                    clientes = Enumerable.Empty<ClienteViewModel>();
                    ModelState.AddModelError(string.Empty, "Erro no servidor. Contate o Administrador.");
                }
                return View(clientes);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente
        [HttpPost]
        public ActionResult Create(ClienteEnderecoViewModel cliente)
        {
            if (cliente == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/");

                var postTast = client.PostAsJsonAsync<ClienteEnderecoViewModel>("clientes", cliente);
                postTast.Wait();
                var result = postTast.Result;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Erro no Servidor. Contacte o Administrador.");

            return View(cliente);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ClienteViewModel cliente = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/clientes");

                var responseTask = client.GetAsync("?id=" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;

                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ClienteViewModel>();
                    readTask.Wait();

                    cliente = readTask.Result;
                }
            }
            return View(cliente);
        }

        // PUT: Cliente
        [HttpPost]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if(cliente == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/");

                var putTask = client.PutAsJsonAsync<ClienteViewModel>("clientes", cliente);
                putTask.Wait();
                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // DELTE: Cliente
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if(id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ClienteViewModel cliente = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/");

                var deleteTask = client.DeleteAsync("clientes/" + id.ToString());
                deleteTask.Wait();
                var result = deleteTask.Result;

                if (result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Cliente
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ClienteViewModel cliente = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61353/api/clientes");

                var responseTask = client.GetAsync("?id=" + id.ToString());
                responseTask.Wait();
                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ClienteViewModel>();
                    readTask.Wait();

                    cliente = readTask.Result;
                }
            }
            return View(cliente);
        }
    }
}