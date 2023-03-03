using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsHexToInt
{
    class Konvertiere
    {
        private static int hexDigitToInt(char digit)
        {
            int wert = 0;
            FormatException bfe = new FormatException("Bitte nur Hexziffern eingeben");
            if (digit >= '0' && digit <= '9')
                wert = digit - '0';
            else
                if (digit >= 'a' && digit <= 'f' || digit >= 'A' && digit <= 'F')
            {
                wert = 10 + char.ToLower(digit) - 'a';
            }
            else
            {
                throw bfe;
            }

            return wert;
        }

        public static int hexToInt32(string input)
        {
            int ergebnis = 0;
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                ergebnis = (ergebnis * 16 + hexDigitToInt(input[i]));
            }

            return ergebnis;
        }
    }
}

