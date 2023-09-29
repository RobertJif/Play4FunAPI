using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Play4Fun.Models.Requests;
using Play4Fun.Models.Responses;
using Play4Fun.Repository;
using Play4Fun.Services.Dtos;
using Play4Fun.Services.Impl;
using Play4Fun.Utils;

namespace Play4Fun.Controllers
{
    [ApiController]
    [Route("api/game-match")]
    public class GameMatchController : ControllerBase
    {

        GameMatchService service;
        Mapper mapper;
        public GameMatchController(ApiDbContext db)
        {
            service = new GameMatchService(db);
            mapper = Mappers.InitializeAutomapper();
        }

        // GET api/game
        [HttpPost]
        public GameMatchResponse GameMatch([FromBody] NewMatchRequest req)
        {
            CreateMatchDto dto = mapper.Map<NewMatchRequest, CreateMatchDto>(req);
            GameMatchDto game = service.Create(dto);
            return mapper.Map<GameMatchDto, GameMatchResponse>(game);
        }


    }
}