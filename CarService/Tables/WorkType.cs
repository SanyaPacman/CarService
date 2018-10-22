using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CarService.Tables
{
    class WorkType: Entity
    {
        public override bool Initialize(DataRow row)
        {
            return false;
        }
        public Specialization Specialization;
        public string Work { get; set; }
        public int Price { get; set; }

    }
}
