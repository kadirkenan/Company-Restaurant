﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.WarehouseAttendant.Controllers
{
    [Area("WarehouseAttendant")]
    public class StorageProductOrder : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
