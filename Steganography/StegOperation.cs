using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Steganography
{
    class StegOperation
    {
        public static Bitmap embedText(string hiddenText, Bitmap oriImage)
        {
            Color currentPixel;
            int R = 0, G = 0, B = 0;
            List<int> messageBits = new List<int>();

            foreach (char c in hiddenText)
            {
                int binary = Convert.ToInt32(Convert.ToString(c, 2));
                Console.WriteLine(binary);
                messageBits.Add(ReverseInt(binary));
                //Console.WriteLine(Convert.ToString(c, 2).PadLeft(8, '0'));
                //Console.Write("\n"+hiddenText[0]);
            }

            currentPixel = oriImage.GetPixel(0, 0);

            int test = currentPixel.R;
            Console.WriteLine(test);
            int test2 = Convert.ToInt32(Convert.ToString(test, 2).PadLeft(8,'0'));
            Console.WriteLine(test2);
            int test3 = Convert.ToInt32(test2.ToString(), 2);
            Console.WriteLine(test3);

            foreach(int i in messageBits)
            {
                Console.WriteLine(i);
            }
            

            for(int row = 0; row < oriImage.Height; row++)
            {
                for(int col = 0; col < oriImage.Width; col++)
                {
                    currentPixel = oriImage.GetPixel(col, row);

                    R = currentPixel.R;
                    G = currentPixel.G;
                    B = currentPixel.B;
                    




                }
            }

            

            return null;
        }

        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }

        /*

        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            // holds the text that will be extracted from the image
            string extractedText = String.Empty;

            // pass through the rows
            for (int i = 0; i < bmp.Height; i++)
            {
                // pass through each row
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    // for each pixel, pass through its elements (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    // get the LSB from the pixel element (will be pixel.R % 2)
                                    // then add one bit to the right of the current character
                                    // this can be done by (charValue = charValue * 2)
                                    // replace the added bit (which value is by default 0) with
                                    // the LSB of the pixel element, simply by addition
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        // if 8 bits has been added, then add the current character to the result text
                        if (colorUnitIndex % 8 == 0)
                        {
                            // reverse? of course, since each time the process happens on the right (for simplicity)
                            charValue = reverseBits(charValue);

                            // can only be 0 if it is the stop character (the 8 zeros)
                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            // convert the character value from int to char
                            char c = (char)charValue;

                            // add the current character to the result text
                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }

    */
    }
}
