using System;
using System.Collections.Generic;

namespace morsecodetranslator
{
    class Program
    {
        static Dictionary<string, string> characterMap = new Dictionary<string, string>
        {
                {"A" ,".-" }, {"B" ,"-..." },{"C" ,"-.-." },{"D" ,"-.." },{"E" ,"." },{"F" ,"..-." }, { "G" ,"--." },
                { "H" ,"...." },{"I" ,".." },{"J" ,".---" },{"K" ,"-.-" },{"L" ,".-.." }, {"M" ,"--" }, {"N" ,"-." },
                { "O" ,"---" },{ "P" ,".--." },{"Q" ,"--.-" }, {"R" ,".-." },{"S" ,"..." },{"T" ,"-" },{"U" ,"..-" },
                {"V" , "...-"}, {"W" ,".--" },{"X" , "-..-"},{"Y" ,"-.--" },{"Z" ,"--.." },{" ", " "},{".", ".-.-.-"},
                {",","--..--" },{"?","..--.."}

        };

        static string Translate(string value)
        {
            string translatedval = "";
            foreach(char c in value.ToCharArray())
            {
                string characterString = c.ToString();
                translatedval += characterMap.GetValueOrDefault(characterString, characterString);
            }
            return translatedval;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------- Morse Code Translator ------");
            Console.WriteLine("What would you like to translate?");
            string totranslate = Console.ReadLine();

            string result = Translate(totranslate.ToUpper());
            Console.WriteLine(result);
        }
    }
}
