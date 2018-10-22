using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CarService.Tables
{
    class Specialization: Entity
    {
        public override bool Initialize(DataRow row)
        {
            return false;
        }
        public string Profession { get; set; }
    }
}
