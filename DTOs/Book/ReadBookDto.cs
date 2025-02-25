﻿using SampleWebAppWithViews.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppWithViews.DTOs.Book
{
    public class ReadBookDto
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Genre Genre { get; set; }
    }
}
