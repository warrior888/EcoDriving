﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavascriptShowdown2.Models
{
    public class HomeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Dictionary<int, string> ListaDanych { get; set; }
    }
}