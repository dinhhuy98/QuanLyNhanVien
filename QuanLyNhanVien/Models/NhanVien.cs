using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Models
{
    public class NhanVien
    {
        public int employeeID { get; set; }
        public string name { get; set; }
        public int gender { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
}
