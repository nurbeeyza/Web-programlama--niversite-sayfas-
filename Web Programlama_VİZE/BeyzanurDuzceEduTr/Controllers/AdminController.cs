using BeyzanurDuzceEduTr.Controllers.Utility;
using BeyzanurDuzceEduTr.Models;
using BeyzanurDuzceEduTr.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Controllers
{
    [CustomHttpsOnlyFilter]
    public class AdminController : Controller
    {
        private BeyzanurDuzceEduTrContext _ctx;
        public AdminController(BeyzanurDuzceEduTrContext context)
        {
            _ctx = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Announcements()
        {
            return View("Announcement", _ctx.Announcements.ToList());
        }
        public IActionResult Users()
        {
            return View("User", _ctx.Users.ToList());
        }

        public ActionResult GetUser(string UserId)
        {
            //Users model = _ctx.Users.Where(x => x.Id == UserId).First();

            //LINQ SORGUSU
            var data = (from a in _ctx.Users
                        where a.Id == UserId
                        select a);

            return PartialView("PV_updateUserView", data.First());
        }


        public JsonResult AddUser(Users model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                model.PasswordHash = Utility.Utility.MD5eDonustur(model.PasswordHash);
                model.CreateDate = DateTime.Now;
                model.NormalizedUserName = model.UserName;
                model.NormalizedEmail= model.Email;
                _ctx.Users.Add(model);
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Kullanıcı oluşturuldu" };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
        public JsonResult UpdateUser(Users model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                model.NormalizedUserName = model.UserName;
                model.NormalizedEmail = model.Email;
                _ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Kullanıcı güncellendi." };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
        public JsonResult DeleteUser(Users model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                Users u = _ctx.Users.Find(model.Id);
                _ctx.Entry(u).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Kullanıcı silindi" };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
        public JsonResult AddAnnouncement(Announcement model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                model.CreateDate = DateTime.Now;
                _ctx.Announcements.Add(model);
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Duyuru oluşturuldu" };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
        public JsonResult DeleteAnnouncement(Announcement model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                Announcement u = _ctx.Announcements.Find(model.AnnouncementId);
                _ctx.Entry(u).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Duyuru silindi" };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
        public ActionResult GetAnnouncement(int AnnouncementId)
        {
            Announcement model = _ctx.Announcements.Find(AnnouncementId);
            return PartialView("PV_AnnouncementUpdate", model);
        }
        public JsonResult UpdateAnnouncement(Announcement model)
        {
            var result = new { statu = "", message = "" };
            try
            {
                _ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _ctx.SaveChanges();
                result = new { statu = "ok", message = "Duyuru güncellendi." };
            }
            catch (Exception ex)
            {
                result = new { statu = "fail", message = ex.Message };
            }

            return Json(result);
        }
    }
}
