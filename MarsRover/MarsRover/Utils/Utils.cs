using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MarsRover.Utils
{
    public class Utils
    {
        public enum Heading
        {
            N = 0,
            E = 1,
            S = 2,
            W = 3
        };

        public static Dictionary<string, Vector2> ForwardVectors = new Dictionary<string, Vector2>
        {
            {"N", new Vector2(0, 1) },
            {"E", new Vector2(1, 0) },
            {"S", new Vector2(0, -1) },
            {"W", new Vector2(-1, 0) },
        };

        public static int Mod(int dividend, int divisor)
        {
            var remainder = dividend % divisor;
            return remainder < 0 ? remainder + divisor : remainder;
        }
    }
}
