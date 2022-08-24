namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder!");
            Game game = new Game();
            game.DieRoll();
            game.Play();
        }
    }
}