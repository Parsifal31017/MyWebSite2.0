﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Models.CompanyViewModels
{
    public class CommentsIndexData
    {
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Owner> Owner { get; set; }
    }
}
