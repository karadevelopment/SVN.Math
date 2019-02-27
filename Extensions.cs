using System;

namespace SVN.Math2
{
    public static class Extensions
    {
        public static int RoundToInt(this float param)
        {
            return (int)Math.Round(param);
        }

        public static int RoundToInt(this double param)
        {
            return (int)Math.Round(param);
        }

        public static int RoundToInt(this decimal param)
        {
            return (int)Math.Round(param);
        }

        public static int FloorToInt(this float param)
        {
            return (int)Math.Floor(param);
        }

        public static int FloorToInt(this double param)
        {
            return (int)Math.Floor(param);
        }

        public static int FloorToInt(this decimal param)
        {
            return (int)Math.Floor(param);
        }

        public static int CeilingToInt(this float param)
        {
            return (int)Math.Ceiling(param);
        }

        public static int CeilingToInt(this double param)
        {
            return (int)Math.Ceiling(param);
        }

        public static int CeilingToInt(this decimal param)
        {
            return (int)Math.Ceiling(param);
        }

        public static int Modulo(this int param, int mod)
        {
            var result = (param % mod);
            return (result < 0 ? result + mod : result);
        }
    }
}