using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hust.Data.Models
{
    public class ChucNangHeThongModels
    {
        public string TenChucNang { get; set; }
        public string Slug { get; set; }
    }

    public class HeThong
    {
        public int IdChucVu { get; set; }
        public List<ChucNangHeThongModels> ChucNangHeThongModelses = new List<ChucNangHeThongModels>();
    }

    public class Child
    {
        public string TenChucNang { get; set; }
        public string Ico { get; set; }
        public string Slug { get; set; }
    }

    public class Parent
    {
        public string TenChucNangParent { get; set; }
        public string Ico { get; set; }
        public string Slug { get; set; }
        public List<Child> DanhSachChucNangChild = new List<Child>();
    }

    public class ChucNangHeThongTreeView
    {
        public List<Parent> ChucNangHeThong = new List<Parent>();
    }
}