using OldPhonePadLibrary;

namespace OldPhonePadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = OldPhonePadFunction.OldPhonePad("8 88777444666*664#");
            Console.WriteLine(result); 
        }
    }
}
