using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleTxt =  "Hello how are yOu I'm FRom P127. Siz tekmiLlesHdIrilmeshleRdensiniZmi. Yox biZ iNTeRnoSionaLLashdirilmishLaRDaniq" ;
            
            ChangeCase(exampleTxt);
        }
        public static void ChangeCase(string str )
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
