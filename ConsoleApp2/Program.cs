using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int inputInt = int.Parse(input);
            if (inputInt % 2 != 0)
            {
                Console.WriteLine("weird");
            }
            else if (inputInt % 2 == 0 && inputInt <= 5)
            {
                Console.WriteLine("NOT weird");
            }
            else if (inputInt % 2 == 0 && inputInt <= 20)
            {
                Console.WriteLine("weird");
            }
            else
            {
                Console.WriteLine("NOT weird");
            }

            for (int i = 0; i <= inputInt; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i <= inputInt; i++)
            {
                    Console.WriteLine(input + "X" + i + "=" + inputInt * i);
            }

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i+ "X" + j + "=" + i * j+" ");
                }
                Console.WriteLine(" ");
            }

            int[] stno = { 1, 2, 3, 4, 5 };
            string[] stname = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] cmpscore = { 80,65,100,98,83};
            int[] pgmscore = { 75,67,93,25,82};
            int[] aniscore = { 60,62,91,50,87};

            while (true)
            {
                Console.WriteLine("輸入座號(1-5)");
                var no = Console.ReadLine();
                int nostno = int.Parse(no);
                int arrayindex = Array.IndexOf(stno, nostno);
                if (arrayindex > -1)
                {
                    Console.WriteLine("姓名:" + stname[arrayindex]);
                    Console.WriteLine("電腦概論:" + cmpscore[arrayindex]);
                    Console.WriteLine("程式設計:" + pgmscore[arrayindex]);
                    Console.WriteLine("動畫設計:" + aniscore[arrayindex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號!!");
                }
            }
        }
    }
}
