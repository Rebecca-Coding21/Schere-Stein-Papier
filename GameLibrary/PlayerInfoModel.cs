﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class PlayerInfoModel
    {
        /// <summary>
        /// Cointains all information about the player
        /// </summary>
        public string Username { get; set; }
        public int NumberOfWins { get; set; }
        public AnswerStatus RecentAnswer { get; set; } = AnswerStatus.EMPTY;
        public AnswerStatus Status { get; set; } = AnswerStatus.EMPTY;
    }
}
