using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Login.Data
{
    public class Website_GYMContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Website_GYMContext() : base("name=Website_GYMContext")
        {
        }

        public System.Data.Entity.DbSet<Login.Models.KHACHHANG> KHACHHANGs { get; set; }

        public System.Data.Entity.DbSet<Login.Models.NHANVIEN> NHANVIENs { get; set; }

        public System.Data.Entity.DbSet<Login.Models.THIETBI> THIETBIs { get; set; }

        public System.Data.Entity.DbSet<Login.Models.KHUYENMAI> KHUYENMAIs { get; set; }

        public System.Data.Entity.DbSet<Login.Models.Video> Videos { get; set; }
    }
}
