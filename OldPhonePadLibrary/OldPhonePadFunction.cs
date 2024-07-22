using System.Text;

namespace OldPhonePadLibrary
{
    public class OldPhonePadFunction
    {
        public static string OldPhonePad(string inputDigits)
        {
            var keyMap = new string[]
            {
                " ",    // 0
                "",     // 1
                "ABC",  // 2
                "DEF",  // 3
                "GHI",  // 4
                "JKL",  // 5
                "MNO",  // 6
                "PQRS", // 7
                "TUV",  // 8
                "WXYZ"  // 9
            };

            //use StringBuilder instead of string so that we can use mutable string
            var result = new StringBuilder();
            var currentChars = new StringBuilder(); 

            foreach (var character in inputDigits)
            {
                // For the end of input
                if (character == '#')
                {
                    break;
                }
                else if (character == '*')
                {
                    // For backspace
                    if (result.Length > 0)
                    {
                        //result.Remove(result.Length - 1, 1);
                        currentChars.Clear();
                    }
                }
                else if (char.IsDigit(character))
                {
                    
                    if (currentChars.Length > 0 && currentChars[0] == character)
                    {
                        currentChars.Append(character);
                    }
                   
                    else
                    {
                        if (currentChars.Length > 0)
                        {
                            ProcessCurrentChars(result, currentChars, keyMap);
                        }
                        currentChars.Clear();
                        currentChars.Append(character);
                    }
                }
                //for the spaces to pause when type same key
                else if (character == ' ')
                {
                    if (currentChars.Length > 0)
                    {
                        ProcessCurrentChars(result, currentChars, keyMap);
                    }
                }
            }
            if (currentChars.Length > 0)
            {
                ProcessCurrentChars(result, currentChars, keyMap);
            }

            return result.ToString();
        }

        private static void ProcessCurrentChars(StringBuilder result, StringBuilder currentChars, string[] keyMap)
        {
            // Convert the character to its integer representation
            //Using ASCII value of '0' = 48
            //For exampl: ASCII value of 2 = 50, 50 - 48 = 2 ;
            int digit = currentChars[0] - '0'; 
            int pressCount = currentChars.Length;
            var letters = keyMap[digit];
            if (letters.Length > 0)
            {
                result.Append(letters[(pressCount - 1) % letters.Length]);
            }
           currentChars.Clear();
        }
    }



}

