﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomerFilterDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
    }
}