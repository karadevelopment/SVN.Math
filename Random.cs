using System;

namespace SVN.Math2
{
    public static class Random
    {
        private static readonly System.Random Generator = new System.Random(DateTime.Now.Millisecond);

        public static int Range(int min, int max)
        {
            var diff = max - min;
            var result = Random.Generator.Next(diff + 1) + min;
            return result;
        }

        public static float Range(float min, float max)
        {
            var diff = max - min;
            var result = min + diff * Random.Generator.NextDouble();
            return (float)result;
        }

        public static double Range(double min, double max)
        {
            var diff = max - min;
            var result = min + diff * Random.Generator.NextDouble();
            return result;
        }
    }
}