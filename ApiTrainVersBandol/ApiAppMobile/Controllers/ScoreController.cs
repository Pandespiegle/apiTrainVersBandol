using ApiTrainVersBandol.Service;
using Microsoft.AspNetCore.Mvc;

namespace ApiTrainVersBandol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController : ControllerBase
    {

        private readonly ILogger<ScoreController> _logger;
        private readonly ScoreService _scoreService;    


        public ScoreController(ILogger<ScoreController> logger)
        {
            _logger = logger;
            _scoreService = new ScoreService();
        }

        [HttpGet(Name = "addScore")]
        public IActionResult Add(string name, int score)
        {
            try
            {
                _scoreService.AddScore(name, score);
                return Ok("");

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}