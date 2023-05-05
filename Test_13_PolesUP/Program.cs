using System;

namespace Test_13_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("Введите version1 - ");
                string version1 = Console.ReadLine();
                Console.Write("Введите version2 - ");
                string version2 = Console.ReadLine();

                string vers1 = "0";
                string vers2 = "0";

                int i = 0;
                int j = 0;

                int h = 0;
                for (; ; vers1 = "0", vers2 = "0", i++, j++)
                {
                    for (; i < version1.Length && version1[i] != '.'; i++)
                    {
                        vers1 += version1[i];
                    }
                    for (; j < version2.Length && version2[j] != '.'; j++)
                    {
                        vers2 += version2[j];
                    }
                    if (Convert.ToInt32(vers1) > Convert.ToInt32(vers2))
                    {
                        h = 1;
                        break;
                    }
                    else if (Convert.ToInt32(vers1) < Convert.ToInt32(vers2))
                    {
                        h = -1;
                        break;
                    }
                    if (i >= version1.Length && j >= version2.Length)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("| "+h+" |");
                Console.WriteLine();
            }
        }
    }
}
