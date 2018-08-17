﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShayneMaravillo.PreLoved.Web.Insfrastructure.Data.Helpers
{
    public class BaseModels
    {
        public Guid? Id { get; set; }
        public DateTime Timestamp { get; set; }
        public BaseModels()
        {
            this.Timestamp = DateTime.UtcNow;
        }
    }
}
