using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Services.Dtos;

namespace Play4Fun.Services
{
    public interface IGameMatchService
    {
        public List<GameMatchDto> GetAll(string gameCode);
    }
}