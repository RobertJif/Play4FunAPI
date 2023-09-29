using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Services.Dtos
{
    public class GameMatchDto : GameMatch
    {

    }

    public class CreateMatchDto
    {
        public string GameCode { get; set; }
        public Player Player { get; set; }
    }
}