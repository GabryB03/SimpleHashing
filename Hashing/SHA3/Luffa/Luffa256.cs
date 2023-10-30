﻿using HashLib;

namespace SimpleHashing.SHA3.Luffa
{
    public class Luffa256
    {
        private static IHash _processor = HashFactory.Crypto.SHA3.CreateLuffa256();

        public static byte[] ComputeHash(byte[] data)
        {
            return _processor.ComputeBytes(data).GetBytes();
        }
    }
}