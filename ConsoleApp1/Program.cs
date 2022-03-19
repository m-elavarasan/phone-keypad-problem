using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string no = "44 33 555 555 666";
            string[] temp = no.Split(' ');

            foreach (string item in temp)
            {
                try
                {
                    int num = Int32.Parse(item);
                    //Console.Write(temp.Length);
                    if (item.Length == 1)
                        pass1(num);
                    if (item.Length == 2)
                        pass2(num);
                    if (item.Length == 3)
                        pass3(num);
                    if (item.Length == 4)
                        pass4(num);
                }
                catch (Exception ex)
                {

                }
            }
        }
        private static void pass1(int num)
        {
            if (num == 2)
                Console.Write('A');
            else if (num == 3)
                Console.Write('D');
            else if (num == 4)
                Console.Write('G');
            else if (num == 5)
                Console.Write('J');
            else if (num == 6)
                Console.Write('M');
            else if (num == 7)
                Console.Write('P');
            else if (num == 8)
                Console.Write('T');
            else if (num == 9)
                Console.Write('W');
            throw new NotImplementedException();
        }
        private static void pass2(int num)
        {
            if (num == 22)
                Console.Write('B');
            else if (num == 33)
                Console.Write('E');
            else if (num == 44)
                Console.Write('H');
            else if (num == 55)
                Console.Write('K');
            else if (num == 66)
                Console.Write('N');
            else if (num == 77)
                Console.Write('R');
            else if (num == 88)
                Console.Write('U');
            else if (num == 99)
                Console.Write('X');
            throw new NotImplementedException();
        }
        private static void pass3(int num)
        {
            if (num == 222)
                Console.Write('C');
            else if (num == 333)
                Console.Write('F');
            else if (num == 444)
                Console.Write('I');
            else if (num == 555)
                Console.Write('L');
            else if (num == 666)
                Console.Write('O');
            else if (num == 777)
                Console.Write('R');
            else if (num == 888)
                Console.Write('V');
            else if (num == 999)
                Console.Write('Y');
            throw new NotImplementedException();
        }
        private static void pass4(int num)
        {
            if (num == 7777)
                Console.Write('S');
            else if (num == 9999)
                Console.Write('Z');
           
            throw new NotImplementedException();
        }
    }
}