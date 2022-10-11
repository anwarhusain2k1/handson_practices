using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _11._10._22.Controllers
{
    public class libController : Controller
    {
        static List<Member> members = new List<Member>();
        // GET: libController
        public ActionResult mem_Index()
        {
            return View(members);
        }

        // GET: libController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: libController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: libController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                members.Add(member);
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: libController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: libController/Edit/5
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

        // GET: libController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: libController/Delete/5
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
