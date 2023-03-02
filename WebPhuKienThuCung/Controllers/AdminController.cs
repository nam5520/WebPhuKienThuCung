using Antlr.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPhuKienThuCung.Models;

namespace WebPhuKienThuCung.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        QLPKTHUCUNGEntities1 db = new QLPKTHUCUNGEntities1();
        public ActionResult Index()
        {
            if (Session["Taikhoanadmin"] == null)
                return RedirectToAction("dangnhap", "Admin");
            else
            {
                ViewBag.Trang = "Trang chủ"; 
                return View();
            }
            
        }
        [HttpGet]
        public ActionResult dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult dangnhap(DangNhapModel model)
        {
            if (ModelState.IsValid)
            {
                ADMIN ad = db.ADMINs.SingleOrDefault(n => n.TENDN == model.tendn && n.MATKHAU == model.matkhau);
                if (ad != null)
                {
                    ViewBag.Thongbao = "Đăng nhập thành công";
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            else
            {

            }
            return View(model);
        }
        public ActionResult dangxuat()
        {
            Session.Clear();
            return RedirectToAction("index","Admin");
        }
        public ActionResult listadmin()
        {
            if (Session["Taikhoanadmin"] == null)
            {
                return RedirectToAction("dangnhap", "Admin");

            }
            else
            {
                var ad = from admin in db.ADMINs select admin;
                return View(ad);
            }
        }
    }
}