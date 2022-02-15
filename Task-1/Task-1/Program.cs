using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Hello how are yOu I'm from P127. Siz tekmiLlesdIrilmesleRdensiniZmi" };
            
            Change(ref arr);
                        
        }
        public static void Change(ref string[] arr)
        {
            
            foreach (string text in arr)
            {
                foreach (char letter in text)
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
