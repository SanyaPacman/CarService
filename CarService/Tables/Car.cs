using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CarService.Tables
{
    class Car: Entity
    {
        public override bool Initialize(DataRow row)
        {
            return false;
        }
        public string NumberCar { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public Client Owner { get; set; }
        public Master Worker { get; set; }
        public WorkType WorkType { get; set; }
    }
}
