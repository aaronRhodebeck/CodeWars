using System;
public static class Kata
{
    public static string GoodVsEvil(string good, string evil)
    {
        var battle = new Battle();
        var scoreGood = battle.ScoreGood(good);
        var scoreEvil = battle.ScoreEvil(evil);
        if (scoreGood > scoreEvil)
        {
            return battle.GoodWins();
        }
        else if (scoreEvil > scoreGood)
        {
            return battle.EvilWins();
        }
        else
        {
            return battle.Draw();
        }

    }

    private class Battle
    {
        private readonly int[] GoodValues = { 1, 2, 3, 3, 4, 10 };
        private readonly int[] EvilValues = { 1, 2, 2, 2, 3, 5, 10 };
        private static readonly string GoodVictory = "Good triumphs over Evil";
        private static readonly string EvilVictory = "Evil eradicates all trace of Good";
        private static readonly string NoVictory = "No victor on this battle field";
        private static readonly string ResultText = "Battle Result: ";
         

        public int ScoreGood(string good)
        {
            var goodPeople = good.Split();
            var score = 0;
            for (int i = 0; i < goodPeople.Length; i++)
            {
                score += int.Parse(goodPeople[i]) * GoodValues[i];
            }
            return score;
        }
        
        public int ScoreEvil(string evil)
        {
            var evilPeople = evil.Split();
            var score = 0;
            for (int i = 0; i < evilPeople.Length; i++)
            {
                score += int.Parse(evilPeople[i]) * EvilValues[i];
            }
            return score;
        }

        public string GoodWins()
        {
            return String.Format("{0}{1}", ResultText, GoodVictory);
        }

        public string EvilWins()
        {
            return String.Format("{0}{1}",ResultText, EvilVictory);
        }

        public string Draw()
        {
            return String.Format("{0}{1}", ResultText, NoVictory);
        }
    }
}