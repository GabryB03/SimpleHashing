﻿using HashLib;

namespace SimpleHashing.Haval
{
    public class Haval_5_192
    {
        private static IHash _processor = HashFactory.Crypto.CreateHaval_5_192();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}