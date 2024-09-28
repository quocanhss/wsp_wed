using Microsoft.AspNetCore.Mvc;
using Them.Data;
using Them.Models;

namespace Them.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {  
            _db = db;
        }
        public IActionResult Index()
        {
            var theloai = _db.TheLoai.ToList();
            ViewBag.TheLoai = theloai;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(TheLoaiModel theloai)
        {

            if (ModelState.IsValid)
            {              
                //xử lý việc tạo mới
                _db.TheLoai.Add(theloai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
