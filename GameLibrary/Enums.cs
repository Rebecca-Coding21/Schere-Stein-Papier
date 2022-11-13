using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// Contains all answers that are possible. AnswerStatus is EMPTY at the beginning of the game
    /// </summary>
    public enum AnswerStatus
    {
        EMPTY = 0,
        SCHERE = 1,
        STEIN = 2,
        PAPIER = 3
    }
}
