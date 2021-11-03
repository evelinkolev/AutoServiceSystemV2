﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceSystem.BusinessObject
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
