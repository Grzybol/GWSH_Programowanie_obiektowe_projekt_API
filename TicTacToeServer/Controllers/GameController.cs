using Microsoft.AspNetCore.Mvc;
using TicTacToeServer.Models;

namespace TicTacToeServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private static Game _game = new Game();

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(_game);
        }

        [HttpPost("move")]
        public IActionResult MakeMove([FromBody] Move move)
        {
            if (_game.MakeMove(move.Row, move.Col, move.Player))
            {
                return Ok(_game);
            }
            return BadRequest("Invalid move");
        }
    }

    public class Move
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Player { get; set; }
    }
}
