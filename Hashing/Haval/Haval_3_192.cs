﻿using HashLib;

namespace SimpleHashing.Haval
{
    public class Haval_3_192
    {
        private static IHash _processor = HashFactory.Crypto.CreateHaval_3_192();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}