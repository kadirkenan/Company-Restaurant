using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Models.ViewModels
{
    public class MenuProductModel
    {
        public string MenuName { get; set; }
        public int MenuCategoryId { get; set; }
        public string Description { get; set; }
        public int MenuPrice { get; set; }
        public bool StockStatus { get; set; }
        public IFormFile MenuImagePath { get; set; }
        public int Unit { get; set; }
    }
}
