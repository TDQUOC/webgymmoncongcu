using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class THIETBI
    {
        [Key]
        [Required(ErrorMessage = "Bạn cần nhập mã thiết bị")]
        [Display(Name = "Mã Thiết Bị")]
        public String matb { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên thiết bị")]
        [Display(Name = "Tên Thiết Bị")]
        public String tentb { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập giá thiết bị")]
        [Display(Name = "Giá Thiết Bị")]
        public float giatb { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập số lượng")]
        [Display(Name = "Số Lượng")]
        public int soluong { get; set; }
    }
}
