using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GaragePortal.App_Code
{
    public class CarData
    {
        public CarData()
        {
            
        }
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Reason { get; set; }
        public double Price { get; set; }
    }
}