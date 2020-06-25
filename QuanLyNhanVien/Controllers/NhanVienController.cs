using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVien.Models;

namespace QuanLyNhanVien.Controllers
{
    public class NhanVienController : Controller
    {
       // private readonly Service _service;

        public IActionResult Index()
        {
            Service _service = new Service();
            return View(_service.Get());
        }
    }
}
