using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp2.Models
{
    public class BlogInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryName = "C#" },
                new Category() { CategoryName = "Asp.Net MVC" },
                new Category() { CategoryName = "Asp.Net WebForm" },
                 new Category() { CategoryName = "Windows Form" }

            };
            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            { 
                new Blog() {Title = "C# Hakkında", Date =DateTime.Now.AddDays(-10), Index=true, Confirmation = false, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "1.jpg", Categoryıd = 1 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "1.jpg", Categoryıd = 1 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-14), Index = false, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "1.jpg", Categoryıd = 1 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "2.jpg", Categoryıd = 2 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-7), Index = false, Confirmation = false, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "2.jpg", Categoryıd = 2 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "2.jpg", Categoryıd = 2 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = false, Confirmation = false, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "2.jpg", Categoryıd = 2 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-17), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "3.jpg", Categoryıd = 3 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "3.jpg", Categoryıd = 3 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = false, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "3.jpg", Categoryıd = 3 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-12), Index = true, Confirmation = false, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "4.jpg", Categoryıd = 4 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "4.jpg", Categoryıd = 4 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-10), Index = false, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "4.jpg", Categoryıd = 4 },
                new Blog() { Title = "C# Hakkında", Date = DateTime.Now.AddDays(-15), Index = true, Confirmation = true, Explanation = "C# bir programlama dilidir.Öğrenmek güzeldir.", Image = "4.jpg", Categoryıd = 4 }

 };
               


            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            }
            context.SaveChanges();


            base.Seed(context);
        }

    }
}