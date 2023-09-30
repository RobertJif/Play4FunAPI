using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Play4Fun.Exceptions;
using Play4Fun.Repository;
using Play4Fun.Repository.Entities;
using Play4Fun.Repository.Impl;
using Play4Fun.Services.Dtos;
using Play4Fun.Utils;

namespace Play4Fun.Services.Impl
{
    public class AuthService : IAuthService
    {
        IConfiguration configuration;

        IPlayerRepository repo;
        JwtHelper jwt;
        Mapper mapper;

        public AuthService(ApiDbContext db, IConfiguration configuration, JwtHelper jwt)
        {
            this.configuration = configuration;
            this.jwt = jwt;
            mapper = Mappers.InitializeAutomapper();
            repo = new PlayerRepository(db);
        }

        public void Create(CreatePlayerDto playerDto)
        {
            var player = repo.Get(playerDto.Username);

            if (player != null)
            {
                throw new AuthException().DuplicateUsername;
            }

            var (password, salt) = jwt.HashPassword(playerDto.Password);

            repo.Create(playerDto.Username, password, salt);
        }

        public PlayerDto? IsCredentialOk(string username, string password)
        {
            var player = repo.Get(username, PlayerStatusEnum.ACTIVE);

            if (player == null)
            {
                return null;
            }

            if (player.Password != jwt.HashPassword(password, player.Salt))
            {
                return null;
            }

            return mapper.Map<PlayerDto>(player);
        }

    }
}