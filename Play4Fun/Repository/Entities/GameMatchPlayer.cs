using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play4Fun.Repository.Entities
{
    public class GameMatchPlayer : BaseEntity
    {
        public Player Player { get; set; }
        public int PlayerId { get; set; }

        public GameMatch GameMatch { get; set; }
        public int GameMatchId { get; set; }
    }
}