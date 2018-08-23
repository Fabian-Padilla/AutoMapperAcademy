using System;
using System.Collections.Generic;
using System.Text;

using AutoMapperAcademy.Input;
using AutoMapperAcademy.Ouput;
using AutoMapper;

namespace AutoMapperAcademy.Profiles
{
    public class InputFlatToProfile : Profile
    {
        public InputFlatToProfile()
        {
            this.CreateMap<InputOrder, List<FlatOutput>>().ConvertUsing<InputToFlatConverter>();
            this.CreateMap<InputItem, FlatOutput>();
        }

        public class InputToFlatConverter : ITypeConverter<InputOrder, List<FlatOutput>>
        {
            public List<FlatOutput> Convert(InputOrder source, List<FlatOutput> destination, ResolutionContext context)
            {
                List<FlatOutput> result = new List<FlatOutput>(source.Items.Count);
                source.Items.ForEach(i =>
                {
                    //result.Add(context.Mapper.Map<FlatOutput>(i));

                    FlatOutput item = context.Mapper.Map<FlatOutput>(i);
                    item.OrderId = source.OrderID;
                    result.Add(item);
                });
                return result;
            }
        }
    }
}
