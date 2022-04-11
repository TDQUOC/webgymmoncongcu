using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class KHUYENMAI
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần nhập mã chương trình")]
        [Display(Name = "Mã Chương Trình")]
        public String mact { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên chương trình")]
        [Display(Name = "Tên Chương Trình")]
        public String tenct { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập nội dung chương trình")]
        [Display(Name = "Nội Dung")]
        public String noidung { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập đối tượng áp dụng")]
        [Display(Name = "Đối Tượng")]
        public String doituong { get; set; }
    }
}
