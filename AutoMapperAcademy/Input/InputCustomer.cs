using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperAcademy.Input
{
    public class InputCustomer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public static InputCustomer BuildInputCustomer()
        {
            return new InputCustomer()
            {
                Name = "Mowgli",
                LastName = "Padilla"
            };
        }
    }
}
