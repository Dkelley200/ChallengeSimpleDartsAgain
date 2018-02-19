﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dart;

namespace ChallengeSimpleDartsAgain
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        private Random _random;

        public Game(string player1name, string player2name)
        {
            _player1 = new Player();
            _player1.Name = player1name;

            _player2 = new Player();
            _player2.Name = player2name;

            _random = new Random();
        }
        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = string.Format( "{0}: {1} <br/>{2}:  {3}", _player1.Name,_player1.Score, _player2.Name, _player2.Score);
            return result += "<br/>Winner" + (_player1.Score> _player2.Score ? _player1.Name : _player2.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Darts dart = new Darts(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
    }
}