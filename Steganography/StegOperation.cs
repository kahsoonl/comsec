using System;
using System.Collections.Generic;
using System.Drawing;

namespace Steganography
{
    class StegOperation
    {
        public static Bitmap embedMessage(string hiddenText, Bitmap oriImage)
        {
            Color currentPixel;
            int[] colorRGB = new int[3];
            List<int> messageValue = new List<int>();
            messageValue = ConvertMessage(messageValue, hiddenText);
            int messageIndex = messageValue.Count;
            int binaryCount = 0;
            int zeroAdded = 0;

            messageValue = invertMessageValue(messageValue);

            for (int row = 0; row < oriImage.Height; row++)
            {
                for(int col = 0; col < oriImage.Width; col++)
                {
                    currentPixel = oriImage.GetPixel(col, row);

                    colorRGB[0] = ConvertEven(currentPixel.R);
                    colorRGB[1] = ConvertEven(currentPixel.G);
                    colorRGB[2] = ConvertEven(currentPixel.B);

                    for (int rgbIndex = 0; rgbIndex < colorRGB.Length; rgbIndex++)
                    {
                        if(messageIndex > 0)
                        {
                            colorRGB[rgbIndex] += messageValue[messageValue.Count - messageIndex] % 2;
                            messageValue[messageValue.Count - messageIndex] /= 2;
                        }

                        if (messageIndex == 0 && zeroAdded < 8)
                        {
                            oriImage.SetPixel(col, row, Color.FromArgb(colorRGB[0], colorRGB[1], colorRGB[2]));
                            zeroAdded++;
                        }
                        else
                        {
                            oriImage.SetPixel(col, row, Color.FromArgb(colorRGB[0], colorRGB[1], colorRGB[2]));
                        }

                        if (zeroAdded == 8)
                        {
                            oriImage.SetPixel(col, row, Color.FromArgb(colorRGB[0], colorRGB[1], colorRGB[2]));
                            return oriImage;
                        }

                        binaryCount++;

                        if (binaryCount % 8 == 0) { messageIndex--; }
                    }
                }
            }
            return oriImage;
        }

        public static string extractMessage(Bitmap stegoImage)
        {
            int[] colorRGB = new int[3];
            int messageValue = 0;
            int binaryCount = 0;
            string extractedMessage = String.Empty;


            for (int row = 0; row < stegoImage.Height; row++)
            {

                for (int col = 0; col < stegoImage.Width; col++)
                {
                    Color currentPixel = stegoImage.GetPixel(col, row);

                    colorRGB[0] = currentPixel.R;
                    colorRGB[1] = currentPixel.G;
                    colorRGB[2] = currentPixel.B;

                    foreach (int pixelValue in colorRGB)
                    {
                        messageValue = messageValue * 2 + pixelValue % 2;
                        binaryCount++;

                        if (binaryCount % 8 == 0)
                        {
                            messageValue = reverseBits(messageValue);
                            

                            if (messageValue == 0) { return extractedMessage; }

                            char word = (char)(messageValue);

                            extractedMessage += word.ToString();
                        }
                    }
                }
            }
            return extractedMessage;
        }

        public static string extractMessageInvert(Bitmap stegoImage)
        {
            int[] colorRGB = new int[3];
            int messageValue = 0;
            int binaryCount = 0;
            string extractedMessage = String.Empty;
            

            for (int row = 0; row < stegoImage.Height; row++)
            {

                for (int col = 0; col < stegoImage.Width; col++)
                {
                    Color currentPixel = stegoImage.GetPixel(col, row);

                    colorRGB[0] = currentPixel.R;
                    colorRGB[1] = currentPixel.G;
                    colorRGB[2] = currentPixel.B;

                    foreach(int pixelValue in colorRGB)
                    {
                        messageValue = messageValue * 2 + pixelValue % 2;
                        binaryCount++;

                        if(binaryCount % 8 == 0)
                        {
                            messageValue = reverseBits(messageValue);

                            if(messageValue == 0) { return extractedMessage; }

                            char word = (char)(messageValue - 1);

                            extractedMessage += word.ToString();
                        }
                    }
                }
            }
            return extractedMessage;
        }

        public static List<int> invertMessageValue(List<int> message)
        {
            for(int count = 0; count < message.Count; count++)
            {
                message[count] = ~message[count];
            }

            return message; 
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

        public static int ConvertEven(int value)
        {
            return value - value % 2;
        }

        public static List<int> ConvertMessage(List<int> messageList, string message)
        {
            foreach(int s in message)
            {
                messageList.Add(s);
            }

            return messageList;
        }
    }
}
