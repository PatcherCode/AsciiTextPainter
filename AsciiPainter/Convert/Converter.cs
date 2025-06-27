using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiPainter.Convert
{
    public class Converter
    {
        public static string GetAsciiToSymbol(char symbol)
        {
            string result = string.Empty;
            foreach (Letter letter in DataConverter.Data1)
            {
                if (letter.StandartLetter == symbol)
                {
                    result = letter.ASCII;
                }
            }
            return result;
        }
        public static string GetAsciiArtToText(string text)
        {
            string Result = string.Empty;
            string[] AsciiSymbols = new string[text.Length];
            for (int i = 0; i < text.Length; i++) 
            {
                AsciiSymbols[i] = GetAsciiToSymbol((text.ToLower())[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    Result += AsciiSymbols[j].Split(new string[] { "\r\n" }, StringSplitOptions.None)[i];
                }
                if (i < 4)
                {
                    Result += "\r\n";
                }
            }
            return Result;
        }
    }
}
