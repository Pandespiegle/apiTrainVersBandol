using ApiTrainVersBandol.Model;
using ApiTrainVersBandol.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiTrainVersBandol.Controllers

{
    [ApiController]
    [Route("[controller]")]

    public class LeaderBoardController : ControllerBase
    {
        private readonly ILogger<LeaderBoardController> _logger;
        private readonly LeaderboardService _leaderboardService;

        public LeaderBoardController(ILogger<LeaderBoardController> logger)
        {
            _logger = logger;
            _leaderboardService = new LeaderboardService();
        }

        [HttpGet(Name = "getLeaderboard")]
        public IActionResult getLeaderboard()
        {
            try
            {
                Leaderboard leaderboard =  _leaderboardService.getLeaderboard();
                return Ok(leaderboard);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
