﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEncryptionStandard
{
    public static class Extentions
    {
        public static string ToHexByte(this byte value, bool withPrefix = false)
        {
            try
            {
                return (withPrefix ? "0x" : string.Empty) + value.ToString("x2");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static byte[] ToArray(this byte[,] matrix)
        {
            List<byte> array = new List<byte>();
            for (int line = 0; line < matrix.Length; line++)
                for (int column = 0; column < 4; column++)
                    array.Add(matrix[line, column]);
            return array.ToArray();
        }

        public static int ToInt(this string value)
        {
            value = value.ToUpper();

            switch (value)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return Convert.ToInt32(value);
                case "A":
                    return 10;
                case "B":
                    return 11;
                case "C":
                    return 12;
                case "D":
                    return 13;
                case "E":
                    return 14;
                case "F":
                    return 15;
                default:
                    throw new Exception("Valor inesperado.");
            }
        }
    }
}
