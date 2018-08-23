using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;
using AutoMapperAcademy.Input;
using AutoMapperAcademy.Ouput;

namespace AutoMapperAcademy.Profiles
{
    public class DeliveryToOrderProfile : Profile
    {
        public DeliveryToOrderProfile()
        {
            this.CreateMap<InputDelivery, OutputOrder>();
            this.RecognizeDestinationPrefixes("Delivery");
        }
    }
}
