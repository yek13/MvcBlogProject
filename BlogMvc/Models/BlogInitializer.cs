﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvc.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            List<Category> kategoriler = new List<Category>()
            {
                new Category(){ KategoriAdi="C#"},
                new Category(){ KategoriAdi="Asp .net MVC"},
                new Category(){ KategoriAdi="Asp .net WebForm"},
                new Category(){ KategoriAdi="Windows Form"},

            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>()
            {

                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="1.jpg",CategoryId=1 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-30),Anasayfa=false,Onay=true,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="1.jpg",CategoryId=1 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Generic List Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=true,Onay=false,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="2.jpg",CategoryId=2 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-20),Anasayfa=false,Onay=false,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="2.jpg",CategoryId=2 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-15),Anasayfa=true,Onay=true,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="3.jpg",CategoryId=3 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false,Onay=false,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="3.jpg",CategoryId=3 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-35),Anasayfa=true,Onay=false,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="4.jpg",CategoryId=4 },
                new Blog(){Baslik="C# Delegates",Aciklama="C# Delegates Hakkında",EklenmeTarihi=DateTime.Now.AddDays(-10),Anasayfa=false,Onay=true,Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında",Resim="4.jpg",CategoryId=4 },

            };
            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}