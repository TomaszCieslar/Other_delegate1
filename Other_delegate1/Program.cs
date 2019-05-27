using System;

namespace Other_delegate1
{
    delegate int ChangeNumber(int i);
    class Program
    {

        static int number = 5;

        public static int AddNumber(int i)
        {
            number += i;
            return number;
        }
        public static int MultiplyNumber(int i)
        {
            number *= i;
            return number;
        }
        public static int GetNumber()
        {
            return number;
        }


        static void Main(string[] args)
        {
            ChangeNumber cn1 = new ChangeNumber(AddNumber);
            ChangeNumber cn2 = new ChangeNumber(MultiplyNumber);

            cn1(5);
            Console.WriteLine("Wartość liczby: {0}", GetNumber());
            cn2(10);
            Console.WriteLine("Wartość liczby: {0}", GetNumber());
            Console.ReadLine();


        }
    }
}
