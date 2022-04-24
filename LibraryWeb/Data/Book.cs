﻿using LibraryWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class Book
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public byte[] Img { get; set; }
        public BookGroup Type { get; set; }
        public uint Date { get; set; }
        public Language Languages { get; set; }
        public string Publish { get; set; }
        public ApplicationUser User { get; set; }

        public Book()
        {
            this.User = new ApplicationUser();
        }
    }
}
