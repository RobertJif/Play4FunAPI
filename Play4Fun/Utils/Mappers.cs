using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Play4Fun.Models.Responses;
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
                #region Repository -> Service
                cfg.CreateMap<Game, GameDto>();

                #endregion

                #region Service -> Controller
                cfg.CreateMap<GameDto, GameResponse>();

                #endregion
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}