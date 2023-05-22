using System;
using System.Security.Cryptography;

namespace VarianceSimulator
{
    internal class RandomGenerator
    {
        private readonly RandomNumberGenerator _generator = RandomNumberGenerator.Create();

        internal double Next()
        {
            // Step 1: Fill an array with 8 random bytes
            byte[] bytes = new byte[8];
            _generator.GetBytes(bytes);

            // Step 2: Bit-shift 11 and 53 based on double mantissa bits
            ulong ul = BitConverter.ToUInt64(bytes) / (1 << 11);
            double d = ul / (double)(1UL << 53);

            return d;
        }
    }
}