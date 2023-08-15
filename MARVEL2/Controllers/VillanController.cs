using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MARVEL2.Controllers
{
    public class VillanController : Controller
    {
        // GET: VillanController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VillanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VillanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VillanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: VillanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VillanController/Edit/5
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

        // GET: VillanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VillanController/Delete/5
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
