using eSports.Entidades;
using eSports.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class JuegoController : Controller
    {
        private IJuegoRepository repository;
        public JuegoController(IJuegoRepository repository)
        {
            this.repository = repository;
        }


        // GET: JuegoController
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: JuegoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JuegoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JuegoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Juego juego)
        {
            try
            {
                repository.Add(juego);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View();
            }
        }

        // GET: JuegoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JuegoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JuegoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JuegoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
