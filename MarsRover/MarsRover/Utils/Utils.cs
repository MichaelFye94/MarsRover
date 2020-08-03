using System.Collections.Generic;
using System.Numerics;

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

        /// <summary>
        /// A custom modulo method that preserves the sign of the divisor, such that -1 mod 4 returns 3, rather than -1
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns>Modulus of the dividend and divisor, retaining the sign of the divisor</returns>
        public static int Mod(int dividend, int divisor)
        {
            var remainder = dividend % divisor;
            return remainder < 0 ? remainder + divisor : remainder;
        }
    }
}
