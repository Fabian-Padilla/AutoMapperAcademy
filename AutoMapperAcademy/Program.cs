using System;
using System.Collections.Generic;

using AutoMapperAcademy.Input;
using AutoMapperAcademy.Ouput;
//using AutoMapperAcademy.Profiles;

using Newtonsoft.Json;

using AutoMapper;

namespace AutoMapperAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mapper.Initialize(cfg => cfg.AddProfile<InputToOutputProfile>());
            Mapper.Initialize(cfg => cfg.AddProfiles(typeof(Program))); //  Busca todos los profiles en el Assembly

            InputOrder inputOrder = InputOrder.BuildInputOrder();
            Console.WriteLine(JsonConvert.SerializeObject(inputOrder, Formatting.Indented));

            Console.ReadKey();
            OutputOrder outputOrder = Mapper.Map<OutputOrder>(inputOrder, opt => opt.Items.Add("IsPayByCard", false));
            InputDelivery inputDelivery = InputDelivery.BuildInputDelivery();
            Mapper.Map(inputDelivery, outputOrder);
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder, Formatting.Indented));

            //List<FlatOutput> outputs = Mapper.Map<List<FlatOutput>>(inputOrder);
            //Console.WriteLine(JsonConvert.SerializeObject(outputs, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
