using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class NHANVIEN
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần nhập mã nhân viên")]
        [Display(Name = "Mã Nhân Viên")]
        public String manv { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên nhân viên")]
        [Display(Name = "Tên Nhân Viên")]
        public String tennv { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập ngày tháng năm sinh")]
        [Display(Name = "Sinh Nhật")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ntnsinh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập địa chỉ")]
        [Display(Name = "Địa Chỉ")]
        public String diachi { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập số điện thoại")]
        [Display(Name = "Điện Thoại")]
        public String sodienthoai { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập chức vụ")]
        [Display(Name = "Chức Vụ")]
        public String chucvu { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập ngày ký hợp đồng")]
        [Display(Name = "Ngày Ký HĐ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngaykyhd { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập ngày hết hạn hợp đồng")]
        [Display(Name = "Ngày Hết Hạn HĐ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayhhhd { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập lương")]
        [Display(Name = "Lương")]
        public float luong { get; set; }
    }
}
