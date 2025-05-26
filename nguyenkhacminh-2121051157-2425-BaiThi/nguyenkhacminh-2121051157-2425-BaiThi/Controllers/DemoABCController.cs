using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace nguyenkhacminh_2121051157_2425_BaiThi.Controllers
{
    public class DemoABCController : Controller
    {
        // GET: DemoABCController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DemoABCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DemoABCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemoABCController/Create
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

        // GET: DemoABCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemoABCController/Edit/5
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

        // GET: DemoABCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemoABCController/Delete/5
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
