using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Play4Fun.Repository;
using Play4Fun.Repository.Entities;
using Play4Fun.Repository.Impl;
using Play4Fun.Services.Dtos;
using Play4Fun.Utils;

namespace Play4Fun.Services.Impl
{
    public class GameMatchService : IGameMatchService
    {
        GameMatchesRepository repo;
        Mapper mapper;
        public GameMatchService(ApiDbContext db)
        {
            repo = new GameMatchesRepository(db);
            mapper = Mappers.InitializeAutomapper();
        }
        public List<GameMatchDto> GetAll(string gameCode)
        {
            List<GameMatch> matches = repo.GetAll(gameCode);
            return mapper.Map<List<GameMatch>, List<GameMatchDto>>(matches);
        }
        public GameMatchDto Create(CreateMatchDto dto)
        {

            throw new NotImplementedException();
        }
    }
}