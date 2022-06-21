using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concencrate
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? GuestTeamId { get; set; }
        public string MatchDate { get; set; }
        public Team Hometeam { get; set; }
        public Team GuestTEam { get; set; }

    }
}
