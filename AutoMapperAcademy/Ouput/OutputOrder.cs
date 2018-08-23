using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapperAcademy.Ouput
{
    public enum PatmentType
    {
        Cash,
        Card
    }
    public class OutputOrder
    {   
        public string OrderId { get; set; }
        public string Created { get; set; }
        public List<OutputItem> Items { get; set; }
        public string Customer { get; set; }        
        public OutputAddresses Addresses { get; set; }
        public PatmentType PaymentType { get; set; }
        public string DeliveryCompany { get; set; }
        public double DeliveryCost { get; set; }
    }
}
