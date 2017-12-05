using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hust.Data.Models
{
    public class CongTacModels
    {
        public string TenCongTac { get; set; }
        public string NguoiLapKeHoachCongTac { get; set; }
        public string PhongBan { get; set; }
        public string DiaDiemCongTac { get; set; }
        public DateTime NgayDiCongTac { get; set; }
        public string NoiDungCongTac { get; set; }
        public List<ChiPhiLapKeHoach> DanhSachChiPhiCongTac = new List<ChiPhiLapKeHoach>();
        public string TongChiPhiCongTac { get; set; }
        public string TrangThai { get; set; }
    }

    public class ChiPhiLapKeHoach
    {
        public string TenNhanVien { get; set; }
        public string TenChiPhi { get; set; }
    }
}