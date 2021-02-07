using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string Image { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Confirmation { get; set; }
        public bool Index { get; set; }


        public int Categoryıd { get; set; }
        public Category category { get; set; }




    }
}