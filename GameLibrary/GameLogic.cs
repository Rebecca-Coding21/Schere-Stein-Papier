using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameLogic
    {
        //public static string FindWinner(string answer)
        //{
        //string result;

        //if (Enum.TryParse<answer.ToUpper()> (Schere, out AnswerStatus)
        //{

        //}

        //return result;
        // }
        public static void GameRound(PlayerInfoModel player1, PlayerInfoModel player2, int i)
        {
          
            AnswerStatus recentAnswer1 = player1.RecentAnswer;
            AnswerStatus recentAnswer2 = player2.RecentAnswer;
            string winner = "";


            //switch (recentAnswer1)
            //{
            //    case AnswerStatus.SCHERE:
            //        switch (recentAnswer2)
            //        {
            //            case AnswerStatus.STEIN:
            //                break;
            //            case AnswerStatus.PAPIER:
            //                break;
            //        }
            //        break;
            //    case AnswerStatus.STEIN:
            //        break;
            //    case AnswerStatus.PAPIER:
            //        break;
            //}

            ////if (recentAnswer1 == recentAnswer2)
            ////{
            ////    Console.WriteLine("Unentschieden");
            ////    winner = "niemand";
            ////}

            ////switch (recentAnswer1)
            ////{
            ////    case AnswerStatus.SCHERE:
            ////        switch (recentAnswer2)
            ////        {
            ////            case AnswerStatus.STEIN:
            ////                winner = player2.Username;
            ////                player2.NumberOfWins += 1; 
            ////            case AnswerStatus.PAPIER:
            ////                winner = player1.Username;
            ////                player1.NumberOfWins += 1;
            ////        }
            ////        break;
            ////    case AnswerStatus.STEIN:
            ////        switch (recentAnswer2)
            ////        {
            ////            case AnswerStatus.SCHERE:
            ////                winner = player1.Username;
            ////                player1.NumberOfWins += 1;
            ////            case AnswerStatus.PAPIER:
            ////                winner = player2.Username;
            ////                player2.NumberOfWins += 1;
            ////        }
            ////        break;
            ////    case AnswerStatus.PAPIER:
            ////        switch (recentAnswer2)
            ////        {
            ////            case AnswerStatus.STEIN:
            ////                winner = player1.Username;
            ////                player1.NumberOfWins += 1;
            ////            case AnswerStatus.SCHERE:
            ////                winner = player2.Username;
            ////                player2.NumberOfWins += 1;
            ////        }
            ////        break;

            ////}

            if (recentAnswer1 == recentAnswer2)
            {
                Console.WriteLine("Unentschieden");
                winner = "niemand";
            }
            else if (recentAnswer1 == AnswerStatus.SCHERE && recentAnswer2 == AnswerStatus.STEIN)
            {
                winner = player2.Username;
                player2.NumberOfWins += 1;
            }
            else if (recentAnswer1 == AnswerStatus.STEIN && recentAnswer2 == AnswerStatus.SCHERE)
            {
                winner = player1.Username;
                player1.NumberOfWins += 1;
            }
            else if (recentAnswer1 == AnswerStatus.PAPIER && recentAnswer2 == AnswerStatus.STEIN)
            {
                winner = player1.Username;
                player1.NumberOfWins += 1;
             }
            else if (recentAnswer1 == AnswerStatus.STEIN && recentAnswer2 == AnswerStatus.PAPIER)
            {
                winner = player2.Username;
                player2.NumberOfWins += 1;
                
            }
            else if (recentAnswer1 == AnswerStatus.PAPIER && recentAnswer2 == AnswerStatus.SCHERE)
            {
                winner = player2.Username;
                player2.NumberOfWins += 1;
             
            }
            else if (recentAnswer1 == AnswerStatus.SCHERE && recentAnswer2 == AnswerStatus.PAPIER)
            {
                winner = player1.Username;
                player1.NumberOfWins += 1;
                
            }
            
            Console.WriteLine($"{winner} gewinnt Runde {i + 1}");
                      
        }

        public static string FindGameWinner(PlayerInfoModel player1, PlayerInfoModel player2)
        {
            string totalWinner;
            if (player1.NumberOfWins > player2.NumberOfWins)
            {
                totalWinner = player1.Username;
            }
            else if (player1.NumberOfWins < player2.NumberOfWins)
            {
                totalWinner = player2.Username;
            }
            else
            {
                totalWinner = "Unentschieden";
            }

            return totalWinner;
        }
    }
}
