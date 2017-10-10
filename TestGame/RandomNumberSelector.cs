namespace TestGame
{
    using System;

    public class RandomNumberSelector
    {

        private int RandNumber(int minNum, int maxNum)
        {
            Random r = new Random();
            int randNum = r.Next(minNum, maxNum);
            return randNum;
        }

        public int GenerateInitialNumber(string level)
        {
            int randNum = 0;

            if (level == "l")
            {
                randNum = RandNumber(0, 12);
            }
            else if (level == "m")
            {
                randNum = RandNumber(0, 100);
            }
            else if (level == "h")
            {
                randNum = RandNumber(0, 500);
            }
          
            return randNum;
        }
    }
}