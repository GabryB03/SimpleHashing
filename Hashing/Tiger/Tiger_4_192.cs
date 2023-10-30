﻿using HashLib;

namespace SimpleHashing.Tiger
{
    public class Tiger_4_192
    {
        private static IHash _processor = HashFactory.Crypto.CreateTiger_4_192();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}