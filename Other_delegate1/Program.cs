using System;
using System.IO;

namespace Other_delegate1
{
   

    class Program
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void PrintMessage(string s);

        public static void WriteToConsole(string s)
        {
            Console.WriteLine("Wiadomosc {0}", s);
        }

        public static void WriteToFile (string s)
        {
            fs = new FileStream("c:\\wiaodmosc.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintMessage pm)
        {
            pm("Witaj Świecie");
        }

        static void Main(string[] args)
        {
            PrintMessage pm1 = new PrintMessage(WriteToConsole);
            PrintMessage pm2 = new PrintMessage(WriteToFile);
            SendString(pm1);
            SendString(pm2);

            Console.ReadLine();

        }
    }
}
