using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Play4Fun.Repository.Entities;
using Play4Fun.Services.Dtos;

namespace Play4Fun.Utils
{
    public class Mappers
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Game, GameDto>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}