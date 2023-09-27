using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Play4Fun.Repository;
using Play4Fun.Repository.Entities;
using Play4Fun.Repository.Impl;
using Play4Fun.Services.Dtos;
using Play4Fun.Utils;

namespace Play4Fun.Services
{
    public class GameService : IGameService
    {
        GameRepository repo;
        Mapper mapper;
        public GameService(ApiDbContext db)
        {
            repo = new GameRepository(db);
            mapper = Mappers.InitializeAutomapper();
        }
        public List<GameDto> GetAllOptions()
        {
            List<Game> games = repo.GetAll();
            return mapper.Map<List<Game>, List<GameDto>>(games);
        }
    }
}