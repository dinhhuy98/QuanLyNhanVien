using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuanLyNhanVien.Models
{
    public class Service
    {
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<NhanVien>));
        public HashSet<NhanVien> NhanVienList { get; set; }
        public Service()
        {
            NhanVienList = new HashSet<NhanVien>()
            {
                new NhanVien{employeeID=1, name = "A",gender = 1, birthday="12/10/1789",phone = "122345456",email="ouou@gmail.com"},
                new NhanVien{employeeID=1, name = "B",gender = 1, birthday="12/10/1789",phone = "122345456",email="ouou@gmail.com"},
                new NhanVien{employeeID=1, name = "C",gender = 0, birthday="12/10/1789",phone = "122345456",email="llj@gmail.com"},
                new NhanVien{employeeID=1, name = "D",gender = 1, birthday="12/10/1789",phone = "122345456",email="dddddu@gmail.com"},
            };
        }

        public NhanVien[] Get() => NhanVienList.ToArray();
        public NhanVien Get(int id) => NhanVienList.FirstOrDefault(a => a.employeeID == id);
        public bool Add(NhanVien nhanVien) => NhanVienList.Add(nhanVien);
        public bool Update(NhanVien nhanVien)
        {
            var b = Get(nhanVien.employeeID);
            return b != null && NhanVienList.Remove(b) && NhanVienList.Add(nhanVien);

        }
        public bool Delete(int id)
        {
            var b = Get(id);
            return b != null && NhanVienList.Remove(b);
        }

    }
}
