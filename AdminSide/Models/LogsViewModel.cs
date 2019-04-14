using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSide.Models
{
    public class LogsViewModel
    {
        public Competition Competition { get; set; }
        public List<TeamChallenge> TeamChallenge { get; set; }
    }
}
