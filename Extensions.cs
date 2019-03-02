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

        public static byte Limit(this byte param, byte min, byte max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static short Limit(this short param, short min, short max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static int Limit(this int param, int min, int max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static long Limit(this long param, long min, long max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static float Limit(this float param, float min, float max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static double Limit(this double param, double min, double max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static decimal Limit(this decimal param, decimal min, decimal max)
        {
            param = Math.Max(param, min);
            param = Math.Min(param, max);
            return param;
        }

        public static byte Approach(this byte param, byte approximation, double momentum = .9)
        {
            var value = (double)param;
            return (byte)value.Approach(approximation, momentum);
        }

        public static short Approach(this short param, short approximation, double momentum = .9)
        {
            var value = (double)param;
            return (short)value.Approach(approximation, momentum);
        }

        public static int Approach(this int param, int approximation, double momentum = .9)
        {
            var value = (double)param;
            return (int)value.Approach(approximation, momentum);
        }

        public static double Approach(this double param, double approximation, double momentum = .9)
        {
            return param * momentum + approximation * (1 - momentum);
        }

        public static double Sigmoid(this double param)
        {
            var value = Math.Pow(Math.E, param);
            var valueMax = Math.Pow(Math.E, param) + 1;
            return value / valueMax;
        }

        public static double SigmoidDerivative(this double param)
        {
            return param.Sigmoid() * (1 - param.Sigmoid());
        }

        public static double Tanh(this double param)
        {
            return Math.Tanh(param);
        }

        public static double TanhDerivative(this double param)
        {
            var value = 1;
            var valueMax = Math.Pow(Math.Cosh(param), 2);
            return value / valueMax;
        }
    }
}