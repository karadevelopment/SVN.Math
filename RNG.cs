using System;

namespace SVN.Math2
{
    public static class RNG
    {
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        public static int Int(int min, int max)
        {
            var diff = max - min;
            var result = min + RNG.Random.Next(diff + 1);
            return result;
        }

        public static float Float(float min, float max)
        {
            var diff = max - min;
            var result = min + diff * RNG.Random.NextDouble();
            return (float)result;
        }

        public static double Double(double min, double max)
        {
            var diff = max - min;
            var result = min + diff * RNG.Random.NextDouble();
            return result;
        }
    }
}