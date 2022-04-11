using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Body Type { get; set; }
    }
}