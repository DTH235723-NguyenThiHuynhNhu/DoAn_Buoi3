using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TaiKhoan
{
    [Key]
    public string TenDangNhap { get; set; }
    [Required]
    public string MatKhau { get; set; }
    public string Quyen { get; set; } // Admin hoặc User
}
