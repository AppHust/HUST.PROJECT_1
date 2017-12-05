using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hust.Data.Models
{
    public class FormLapKeHoachCongTacModels
    {
        public string TenCongTac { get; set; }
        public string NguoiLapKeHoach { get; set; }
        public int IdPhongBan { get; set; }
        public string DiaDiemCongTac { get; set; }
        public DateTime NgayDiCongTac { get; set; }
        public string ChiTietCongTac { get; set; }
        public string TongChiPhiCongTac { get; set; }
        public string DataTblDanhSachChiPhi { get; set; }
    }
}