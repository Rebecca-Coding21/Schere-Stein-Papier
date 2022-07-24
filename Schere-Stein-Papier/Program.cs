using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace Schere_Stein_Papier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            //Ask users for their name
            //Ask player 1 for answer
            //ask player 2 for answers
            //count rounds
            //



            PlayerInfoModel activePlayer = CreatePlayer("Player 1: ");
            PlayerInfoModel opponent = CreatePlayer("Player 2: ");

            string winner = GameLogic.FindWinner(AskForAnswer());

            DisplayWinnerofRound(activePlayer);

            

            Console.ReadLine();
        }

        private static string AskForAnswer(string message)
        {
            string answer = Console.ReadLine();

            return answer;
            
        }

       
        private static void WelcomeMessage()
        {
            Console.WriteLine("Willkommen zu Schere-Stein-Papier");
            Console.WriteLine("erstellt von Rebecca :)");
        }

        private static PlayerInfoModel CreatePlayer(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            output.Username = AskForUsername();

            //output.NumberOfWins = GameLogic.FindWinner(player);

            string answer = AskForAnswer("Schere/Stein/Papier?: ");

            return output;
        }

        private static string AskForUsername()
        {
            Console.Write("Wie heißt du: ");
            string output= Console.ReadLine();

            return output;
        }
    }
}
