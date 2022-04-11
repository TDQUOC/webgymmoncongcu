using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class KHACHHANG
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần nhập mã khách hàng")]
        [Display(Name = "Mã Khách Hàng")]
        public String makh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên khách hàng")]
        [Display(Name = "Tên Khách Hàng")]
        public String tenkh { get; set; }

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

        [Required(ErrorMessage = "Bạn cần nhập loại khách hàng")]
        [Display(Name = "Loại Khách Hàng")]
        public String loaikh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập ngày đăng ký")]
        [Display(Name = "Ngày Đăng Ký")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngaydk { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập ngày hết hạn")]
        [Display(Name = "Ngày Hết Hàng")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayhh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập phí dịch vụ")]
        [Display(Name = "Phí Dịch Vụ")]
        public float lephi { get; set; }
    }
}
