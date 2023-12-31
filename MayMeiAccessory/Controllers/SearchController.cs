﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MayMeiAccessory.Models;


namespace MayMeiAccessory.Controllers
{
    public class SearchController : Controller
    {
        private readonly dbMayMeiStoreContext _context;
        public SearchController(dbMayMeiStoreContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductSearchPartialView", null);
            }
            ls = _context.Products.AsNoTracking()
                                  .Include(a => a.Cat)
                                  .Where(x => x.ProductName.Contains(keyword))
                                  .OrderByDescending(x => x.ProductName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListProductSearchPartialView", null);
            }
            else
            {
                return PartialView("ListProductSearchPartialView", ls);
            }
        }

    }
}
