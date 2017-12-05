using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hust.Data.Models
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { set; get; }
        public string UserName { set; get; }
        public int? IdChucVu { set; get; }
    }
}