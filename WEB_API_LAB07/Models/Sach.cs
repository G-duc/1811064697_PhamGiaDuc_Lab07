﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_LAB07.Models
{
    public class Sach
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}