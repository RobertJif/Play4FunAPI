using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Play4Fun.Repository.Entities;

namespace Play4Fun.Services.Dtos
{
    public class PlayerDto : Player
    {

    }

    public class CreatePlayerDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}