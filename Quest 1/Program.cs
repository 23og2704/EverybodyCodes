using System;
using System.IO;

namespace Quest_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("text.txt");
            int potionCount = 0;
            foreach (char c in input)
            {
                if (c == 'A')
                {
                    potionCount++;
                }
                else if (c == 'x')
                {
                    potionCount--;
                }
                else if (c == 'B')
                {
                    potionCount += 2;
                }
                else if (c == 'C')
                {
                    potionCount = potionCount + 4;
                }
                else if (c == 'D')
                {
                    potionCount = potionCount + 6;
                }


                Console.WriteLine(potionCount);
            }
                //for (int i = 0; i < input.Length; i += 2)
                //{
                //    char temp = input[i];
                //    char temp2 = input[i + 1];
                //    string temp3 = input[i] + input[i + 1].ToString();

                //    Console.WriteLine(temp3);
                //    if (temp3 == "BC")
                //    {
                //        potionCount += 6;
                //    }
                //    else if (temp3 == "DD")
                //    {
                //        potionCount += 12;
                //    }
                //    else if (temp3 == "CA")
                //    {
                //        potionCount += 5;
                //    }
                //    else if (temp3 == "xA")
                //    {
                //        continue;
                //    }
                //    else if (temp3 == "xD")
                //    {
                //        potionCount += 5;
                //    }
                //}



                Console.WriteLine(potionCount);
                Console.ReadKey();

            }
        }

    }
