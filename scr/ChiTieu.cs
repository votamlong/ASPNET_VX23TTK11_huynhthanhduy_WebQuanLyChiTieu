using System;

namespace WebQuanLyChiTieu.Models
{
    public class ChiTieu
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public string NoiDung { get; set; }
        public decimal SoTien { get; set; }
    }
}
