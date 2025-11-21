using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.AutoMapping.EmployeeSample
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            //create ILogger factory
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.SetMinimumLevel(LogLevel.Information);
            });

            //provide all the mapping configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDTO>();
            }, loggerFactory);
            //create mapper instance
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
