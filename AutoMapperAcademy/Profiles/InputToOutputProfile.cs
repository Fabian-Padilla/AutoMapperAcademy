using System;
using AutoMapper;

using AutoMapperAcademy.Input;
using AutoMapperAcademy.Ouput;

namespace AutoMapperAcademy.Profiles
{
    public class InputToOutputProfile : Profile
    {
        public InputToOutputProfile()
        {
            this.CreateMap<InputOrder, OutputOrder>()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => $"{src.Customer.Name} {src.Customer.LastName}"))
                .ForMember(dest => dest.Addresses, opt => opt.ResolveUsing(
                    (src, dest, member, context) =>
                    {
                        return new OutputAddresses()
                        {
                            ShippingAddres = context.Mapper.Map<string>(src.ShippingAddress),
                            BillingAddress = context.Mapper.Map<string>(src.BillingAddress)
                        };
                    }))
                .ForMember(dest => dest.PaymentType, opt => opt.ResolveUsing(
                    (src, dest, member, context) =>
                    {
                        return context.Items.ContainsKey("IsPayByCard") && context.Items["IsPayByCard"].Equals(true) ? PatmentType.Card : PatmentType.Cash;
                    }))
                .AfterMap((src, dest) => dest.Created = DateTime.Now.ToString("O"));

            this.CreateMap<InputItem, OutputItem>();
            this.CreateMap<InputAddress, string>().ConstructUsing( (src) => $"{src.Street}, {src.City} {src.Zip}");
        }
    }
}
