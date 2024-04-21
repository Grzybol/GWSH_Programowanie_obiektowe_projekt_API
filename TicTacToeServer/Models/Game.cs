namespace TicTacToeServer.Models
{
    public class Game
    {
        public List<List<string>> Board { get; set; } = new List<List<string>>
        {
            new List<string> { null, null, null },
            new List<string> { null, null, null },
            new List<string> { null, null, null }
        };

        public string CurrentTurn { get; set; } = "X";

        public bool MakeMove(int row, int col, string player)
        {
            if (row >= 0 && row < 3 && col >= 0 && col < 3 && Board[row][col] == null && player == CurrentTurn)
            {
                Board[row][col] = player;
                CurrentTurn = (CurrentTurn == "X" ? "O" : "X");
                return true;
            }
            return false;
        }
    }
}
