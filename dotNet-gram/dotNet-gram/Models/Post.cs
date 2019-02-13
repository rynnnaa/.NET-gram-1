﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_gram.Models
{
    public class Post
    {
        public int ID { get; set; }
        
        public string Title { get; set; }

        public string Caption { get; set; }

        public int Rating { get; set }

        public string URL { get; set; }
    }
}