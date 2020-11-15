﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLCN_WEB.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public int UserTypeID { get; set; }
    }
}
