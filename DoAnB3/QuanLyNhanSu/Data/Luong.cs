using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class Luong
    {
        [Key]
        public int Id { get; set; }
        public double LuongCoBan { get; set; }
        public double ThucLanh { get; set; }

        public int NhanVienId { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
