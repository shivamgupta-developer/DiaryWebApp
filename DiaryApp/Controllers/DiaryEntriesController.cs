using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDBContext _db;

        public DiaryEntriesController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntries = new List<DiaryEntry>();
            objDiaryEntries = _db.DiaryEntries.ToList();
            return View(objDiaryEntries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if (obj != null && obj.Content.Length<3)
            {
                ModelState.AddModelError("Content","Content is too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);            
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? objDiaryEntry = _db.DiaryEntries.Find(id);
            if (objDiaryEntry == null)
            {
                return NotFound();
            }

            return View(objDiaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Content.Length < 3)
            {
                ModelState.AddModelError("Content", "Content is too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? objDiaryEntry = _db.DiaryEntries.Find(id);
            if (objDiaryEntry == null)
            {
                return NotFound();
            }

            return View(objDiaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
                _db.DiaryEntries.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
