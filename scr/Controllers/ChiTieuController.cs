using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebQuanLyChiTieu.Models;

namespace WebQuanLyChiTieu.Controllers
{
    public class ChiTieuController : Controller
    {
        // Hàm lấy danh sách từ Session
        private List<ChiTieu> GetDanhSach()
        {
            if (Session["ds"] == null)
            {
                Session["ds"] = new List<ChiTieu>();
            }
            return (List<ChiTieu>)Session["ds"];
        }

        // Hiển thị danh sách
        public ActionResult Index()
        {
            var ds = GetDanhSach();
            return View(ds);
        }

        // Form thêm mới
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Nhận dữ liệu từ form
        [HttpPost]
        public ActionResult Create(ChiTieu item)
        {
            var ds = GetDanhSach();
            item.Id = ds.Count + 1;   // Tạo ID tự tăng
            ds.Add(item);

            // Lưu lại vào session
            Session["ds"] = ds;

            return RedirectToAction("Index");
        }
    }
}
