﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MayMeiAccessory.Models;

namespace MayMeiAccessory.Controllers
{
    public class PageController : Controller
    {
        private readonly dbMayMeiStoreContext _context;
        public PageController(dbMayMeiStoreContext context)
        {
            _context = context;
        }
        // GET: /<controller>/

        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");

            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(page);
        }
    }
}
