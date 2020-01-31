using System;
using System.IO;
using System.Text;

namespace FindMeter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { };
            int countFloor = 0;
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("C://USers/adhee/source/repos/FindMeter/question01_input.txt"))
                {
                    // Read the stream to a string
                    string line = sr.ReadToEnd();
                    int l = line.Length;
                    charArray = new char[line.Length];

                    using (StringReader stringReader = new StringReader(line))
                    {
                        // Read characters from the string into the array.
                        stringReader.Read(charArray, 0, line.Length);

                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(')
                {
                    countFloor++;
                }
                else
                {
                    countFloor--;
                }
            }


            Console.WriteLine("The instruction will take the worker in to the {0} th floor ", countFloor);

            Console.ReadLine();
        }
    }
}
