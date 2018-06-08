using System.Collections.Generic;

namespace CodewarsKatas
{
    public class MorseCodeDecoder
    {
        public static string Decode(string morseCode)
        {
            var phrase = string.Empty;
            var dict = new MorseDict();
            
            foreach (var morseChar in morseCode.Split(' '))
            {
                phrase += dict.Get(morseChar).ToUpper();
            }
            return phrase;
        }
    }

    public class MorseDict : Dictionary<string,string>
    {
        public MorseDict()
        {
            Add(".-", "a");
            Add("-...", "b");
            Add("-.-.", "c");
            Add("-..", "d");
            Add(".", "e");
            Add("..-.", "f");
            Add("--.", "g");
            Add("....", "h");
            Add("..", "i");
            Add(".---", "j");
            Add("-.-", "k");
            Add(".-..", "l");
            Add("--", "m");
            Add("-.", "n");
            Add("---", "o");
            Add(".--.", "p");
            Add("--.-", "q");
            Add(".-.", "r");
            Add("...", "s");
            Add("-", "t");
            Add("..-", "u");
            Add("...-","v");
            Add(".--", "w");
            Add("-..-", "x");
            Add("-.--", "y");
            Add("--..", "z");
            Add("", " ");
            Add(".----", "1");
            Add("..---", "2");
            Add("...--", "3");
            Add("....-", "4");
            Add(".....", "5");
            Add("-....", "6");
            Add("--...", "7");
            Add("---..", "8");
            Add("----.", "9");
            Add("-----", "0");
        }

        public string Get(string key)
        {
            string value = string.Empty;
            this.TryGetValue(key, out value);
            return value;
        }
    }
}