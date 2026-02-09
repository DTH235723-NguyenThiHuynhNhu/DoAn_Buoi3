using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Data
{
    public class ChamCong
    {

        [Key]
        public int Id { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int SoNgayCong { get; set; }

        public int NhanVienId { get; set; }
        public virtual NhanVien NhanVien { get; set; }

    }
}
