using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace PracticeCoreCDPs.Areas.Factory.Core
{
    public static class ColorHelper
    {
        static List<int> numCheck = new List<int>();
        public static Color ConvertToColor(int oleColor)
        {
            Color[] colors = {Color.Red, Color.Aqua, Color.Blue, Color.Yellow, Color.Orange, Color.Green, Color.Brown, Color.DarkOrchid};
            var randomNum = RandomNumber(0, colors.Length - 1);
            while (numCheck.Contains(randomNum))
                randomNum = RandomNumber(0, colors.Length - 1);
            numCheck.Add(randomNum);

            return colors[randomNum];
            //return ColorTranslator.FromOle(ColorTranslator.ToOle());
            //return ColorConverter.ConvertFromString(color.Name);
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
