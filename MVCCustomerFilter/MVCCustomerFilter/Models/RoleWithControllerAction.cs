﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomerFilterDemo.Models
{
    public class RoleWithControllerAction
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string RoleIds { get; set; }
    }
}