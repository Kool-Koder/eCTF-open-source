using System.Collections.Generic;

namespace UserSide.Models
{
    public class TeamDetailsViewModel
    {
        public Team Team { get; set; }
        public List<Challenge> Challenges { get; set; }
    }
}
