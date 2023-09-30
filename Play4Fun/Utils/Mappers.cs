using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Play4Fun.Models.Requests;
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
                cfg.CreateMap<GameMatch, GameMatchDto>();
                cfg.CreateMap<Player, PlayerDto>();

                #endregion

                #region Service -> Controller
                cfg.CreateMap<GameDto, GameResponse>();
                cfg.CreateMap<GameMatchDto, GameMatchResponse>().ForMember(to => to.MatchId, opt => opt.MapFrom(s => s.Id));
                cfg.CreateMap<RegisterRequest, CreatePlayerDto>();

                #endregion

                #region Controller -> Client

                cfg.CreateMap<FluentValidation.Results.ValidationFailure, ErrorResponse>();

                #endregion
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}