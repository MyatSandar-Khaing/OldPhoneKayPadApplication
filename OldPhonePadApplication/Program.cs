using OldPhonePadLibrary;

namespace OldPhonePadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = OldPhonePadFunction.OldPhonePad("227*#");
            Console.WriteLine(result); 
        }
    }
}
