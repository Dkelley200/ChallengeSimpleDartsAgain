using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dart;

namespace ChallengeSimpleDartsAgain
{
    public class Score
    {
        public static void ScoreDart(Player player, Darts darts)
        {
            int score = 0;
            if (darts.tripleRing) score = darts.Score * 3;
            else if (darts.doubleRing) score = darts.Score * 2;
            else score = darts.Score;

            if (darts.Score == 0 && darts.tripleRing) score = 50;
            else if (darts.Score == 0) score = 25;
            player.Score += score;
        }
    }
}