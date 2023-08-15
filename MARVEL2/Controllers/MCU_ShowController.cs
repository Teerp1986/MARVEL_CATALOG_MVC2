using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MARVEL2.Controllers
{
    public class MCU_ShowController : Controller
    {
        // GET: MCU_ShowController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MCU_ShowController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MCU_ShowController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MCU_ShowController1/Create
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

        // GET: MCU_ShowController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MCU_ShowController1/Edit/5
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

        // GET: MCU_ShowController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MCU_ShowController1/Delete/5
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
