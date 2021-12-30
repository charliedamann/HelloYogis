using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloYogis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TeamMemberController> _logger;

        public TeamMemberController(ILogger<TeamMemberController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<TeamMember> Get()
        {
            List<TeamMember> members = new List<TeamMember>();
            members.Add(new TeamMember { Name = "Yogi", Role = "Team Mascot" });
            members.Add(new TeamMember { Name = "Luna", Role = "Executive Fluffball" });
            members.Add(new TeamMember { Name = "Burton Guster", Role = "VP of Lounging" });
            return members;
        }
    }
}
