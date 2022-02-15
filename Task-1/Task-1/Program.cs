using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] exampleArr = { "Hello how are yOu I'm FRom P127. Siz tekmiLlesHdIrilmeshleRdensiniZmi. Yox biZ iNTeRnoSionaLLashdirilmishLaRDaniq" };
            
            Change(exampleArr);
        }
        public static void Change(string[] arr)
        {
            foreach (string str in arr)
            {
                foreach (char letter in str)
                {
                    if (char.IsLower(letter))
                    {
                        Console.Write(char.ToUpper(letter));
                    }
                    else
                    {
                        Console.Write(char.ToLower(letter));
                    }
                }
            }
        }
    }
}
