﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CarService.Tables
{
    class Client: Entity
    {
        public override bool Initialize(DataRow row)
        {
            return false;
        }

        public string Name { get; set; }

        public int AllTimeSumm { get; set; }

        public double Sale { get; set; }
    }
}
