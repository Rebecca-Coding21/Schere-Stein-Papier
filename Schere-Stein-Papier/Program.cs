using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace Schere_Stein_Papier
{
    class Program
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
            AskForGameInformation(activePlayer, opponent);

            string gameWinner = GameLogic.FindGameWinner(activePlayer, opponent);
            DisplayWinner(gameWinner);

            //string winner = GameLogic.FindWinner(AskForAnswer());
                       

            Console.ReadLine();
        }

        private static void DisplayWinner(string gameWinner)
        {
            Console.WriteLine($"{gameWinner} hat das Spiel gewonnen!");
        }

        private static void AskForGameInformation(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
             for (int i = 0; i < 3; i++)
            {
                

                activePlayer.RecentAnswer = AskForAnswer(activePlayer.Username);
                opponent.RecentAnswer = AskForAnswer(opponent.Username);

                GameLogic.GameRound(activePlayer, opponent, i);
                
            }
            
        }

        private static AnswerStatus AskForAnswer(string username)
        {
            Console.WriteLine($"{username}, du bist dran: ");
            Console.Write("Schere/Stein/Papier?: ");
            string stringAnswer = Console.ReadLine().ToUpper();
            AnswerStatus answer = AnswerStatus.EMPTY;

            try
            {
                var success = Enum.TryParse(stringAnswer, out answer);

                if (!success)
                    throw new Exception();

     
            }
            catch
            {
                Console.WriteLine("Bitte neue Antwort eingeben, es ist ein Fehler aufgetreten (Schere/Stein/Papier)!");
                return AskForAnswer(username);
                
            }




            return answer;
            
        }

       
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

            

            //output.NumberOfWins = GameLogic.FindWinner(player);
            //output.RecentAnswer = AskForAnswer("Schere/Stein/Papier?: ");

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
