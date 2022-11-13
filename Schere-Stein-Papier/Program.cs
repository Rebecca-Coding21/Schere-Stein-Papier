using System;
using GameLibrary;

namespace Schere_Stein_Papier
{
    class Program
    {   
        /// <summary>
        /// Starts the game
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1: ");
            PlayerInfoModel opponent = CreatePlayer("Player 2: ");
            AskForGameInformation(activePlayer, opponent);

            string gameWinner = GameLogic.FindGameWinner(activePlayer, opponent);
            DisplayWinner(gameWinner);

            Console.ReadLine();
        }

        /// <summary>
        /// Writes the name of the winner to the console
        /// </summary>
        /// <param name="gameWinner">name of the person who won the game<param>
        private static void DisplayWinner(string gameWinner)
        {
            Console.WriteLine($"{gameWinner} hat das Spiel gewonnen!");
        }
 

        /// <summary>
        /// Gets all information that are needed for one round of the game (recent answer, winner of one round)
        /// </summary>
        /// <param name="activePlayer"></param>
        /// <param name="opponent"></param>
        private static void AskForGameInformation(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            for (int i = 0; i < 3; i++)
            {


                activePlayer.RecentAnswer = AskForAnswer(activePlayer.Username);
                opponent.RecentAnswer = AskForAnswer(opponent.Username);

                GameLogic.GameRound(activePlayer, opponent, i);

            }

        }


        /// <summary>
        /// Displays which players turn it is and asks the player for his answer
        /// </summary>
        /// <param name="username">name of the current player who's turn it is</param>
        /// <returns>answer of the player (must be part of AnswerStatus - SCHERE/STEIN/PAPIER)</returns>
        private static AnswerStatus AskForAnswer(string username)
        {
            Console.WriteLine($"{username}, du bist dran: ");
            Console.Write("Schere/Stein/Papier?: ");
            string stringAnswer = Console.ReadLine().ToUpper();
            AnswerStatus answer = AnswerStatus.EMPTY;

            CatchException(stringAnswer, answer, username);

            return answer;
        }


        /// <summary>
        /// Checks if the answer given by the user is valid (Schere/Stein/Papier - caseunsensitive)
        /// </summary>
        /// <param name="stringAnswer">answer written to the console by the user</param>
        /// <param name="answer">answer of the player, must be SCHERE/STEIN/Papier</param>
        /// <param name="username">name of the player who wrote a wrong input</param>
        private static void CatchException(string stringAnswer, AnswerStatus answer, string username)
        {
            try
            {
                if (int.TryParse(stringAnswer, out _))
                    throw new Exception();

                if (Enum.TryParse(stringAnswer, out answer) == false)
                {
                    throw new Exception();
                }

            }
            catch
            {
                Console.WriteLine("Bitte neue Antwort eingeben, es ist ein Fehler aufgetreten (Schere/Stein/Papier)!");
                AskForAnswer(username);

            }
        }
        /// <summary>
        /// Displays a welcome message in the console when the program is started
        /// </summary>
        private static void WelcomeMessage()
        {
            Console.WriteLine("Willkommen zu Schere-Stein-Papier");
            Console.WriteLine("erstellt von Rebecca :)");
        }


        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine(playerTitle);
            output.Username = AskForUsername();


            return output;
        }

        /// <summary>
        /// Asks the users for their name
        /// </summary>
        /// <returns>username</returns>
        private static string AskForUsername()
        {
            Console.Write("Wie heißt du: ");
            string output = Console.ReadLine();

            return output;
        }
    }
}
