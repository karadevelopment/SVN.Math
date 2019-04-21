using System;

namespace SVN.Math2
{
    public static class Random2
    {
        private static readonly Random Generator = new Random((int)DateTime.Now.Ticks);

        public static int Range(int min, int max)
        {
            var diff = max - min;
            var result = Random2.Generator.Next(diff + 1) + min;
            return result;
        }

        public static float Range(float min, float max)
        {
            var diff = max - min;
            var result = min + diff * Random2.Generator.NextDouble();
            return (float)result;
        }

        public static double Range(double min, double max)
        {
            var diff = max - min;
            var result = min + diff * Random2.Generator.NextDouble();
            return result;
        }

        public static bool Bool()
        {
            return Random2.Range(1, 2) == 1;
        }
    }
}