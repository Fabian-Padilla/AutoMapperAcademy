using System;
using System.Collections.Generic;
using System.Text;



namespace AutoMapperAcademy.Input
{
    public class InputOrder
    {
        public string OrderID { get; set; }
        public DateTime Created { get; set; }
        public List<InputItem> Items { get; set; }
        public InputCustomer Customer { get; set; }
        public InputAddress ShippingAddress { get; set; }
        public InputAddress BillingAddress { get; set; }
        public static InputOrder BuildInputOrder() {
            return new InputOrder
            {
                OrderID = "12345-6789",
                Created = DateTime.Now,
                Items = new List<InputItem>()
                {
                    new InputItem(){ Name = "Hat", Cost = 25  },
                    new InputItem(){ Name = "T-shirt", Cost = 250  }
                },
                Customer = InputCustomer.BuildInputCustomer(),
                ShippingAddress = new InputAddress()
                {
                    Street = "Madia Circle",
                    City = "La mirada",
                    Zip = "90623"
                },
                BillingAddress = new InputAddress()
                {
                    Street = "Boulevaard Popocatepetl",
                    City = "Valle Dorado",
                    Zip = "12345"
                }
            };              
        }
    }
}
