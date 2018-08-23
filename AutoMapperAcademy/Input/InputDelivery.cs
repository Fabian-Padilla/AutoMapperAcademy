using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperAcademy.Input
{
    public class InputDelivery
    {
        public string Company { get; set; }
        public double Cost { get; set; }
        public static InputDelivery BuildInputDelivery() {
            return new InputDelivery() { Company = "DHL", Cost = 750 };
        }
    }
}
