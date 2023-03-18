using BeyzanurDuzceEduTr.Models;
using BeyzanurDuzceEduTr.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyzanurDuzceEduTr.Controllers
{
    public class Duyurular : ViewComponent
    {
        BeyzanurDuzceEduTrContext _ctx;
        public Duyurular(BeyzanurDuzceEduTrContext context)
        {
            _ctx = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_ctx.Announcements.ToList());
        }
    }

}