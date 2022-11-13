using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameLogic
    {
        /// <summary>
        /// Checks which player won the round and counts the number of wins for each player
        /// </summary>
        /// <param name="player1">information for player 1 (Username, number of wins, recent answer, status)</param>
        /// <param name="player2">information for player 2 (Username, number of wins, recent answer, status)</param>
        /// <param name="i">index of the current round</param>
        public static void GameRound(PlayerInfoModel player1, PlayerInfoModel player2, int i)
        {
          
            AnswerStatus recentAnswer1 = player1.RecentAnswer;
            AnswerStatus recentAnswer2 = player2.RecentAnswer;
            string winner = "";


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


        /// <summary>
        /// Finds the winner of the whole game according to the winner of each round
        /// </summary>
        /// <param name="player1">information for player 1 (Username, number of wins, recent answer, status)</param>
        /// <param name="player2">information for player 2 (Username, number of wins, recent answer, status)</param>
        /// <returns>name of the player who won the whole game</returns>
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
