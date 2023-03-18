using BeyzanurDuzceEduTr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using BeyzanurDuzceEduTr.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BeyzanurDuzceEduTr.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : Controller
    {
        private BeyzanurDuzceEduTrContext _ctx;
        private SignInManager<Users> _signInManager;
        private UserManager<Users> _usermanager;

        public AuthenticationController(BeyzanurDuzceEduTrContext context, UserManager<Users> userManager, SignInManager<Users> signInManager)
        {
            _ctx = context;
            _signInManager = signInManager;
            _usermanager = userManager;
        }
        //Functons
        [HttpPost]
        public async Task<JsonResult> Login(string userId, string password)
        {
            var result = new { statu = "", message = "" };
            string Pwd = Utility.Utility.MD5eDonustur(password);
            var user = await _usermanager.FindByNameAsync(userId);
            
            if (user.UserName == userId && user.PasswordHash == Pwd)
            {
                result = new { statu = "ok", message = "" };
                Utility.Utility.isLogin = true;
                var sonuc = await _signInManager.PasswordSignInAsync(user.UserName, user.PasswordHash, true, false);
            }

            return Json(result);
        }
    }
}
