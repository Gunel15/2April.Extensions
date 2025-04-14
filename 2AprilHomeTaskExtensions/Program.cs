namespace _2AprilHomeTaskExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.IsOdd());           //Extension methoddur
            Console.WriteLine(Helper.IsEven(5));   //adi static method kimi,classsa muraciet edir
            string input = "hds5hdt";
            Console.WriteLine(input.HasDigit());
            string password = "hsgfThtk7l";
            Console.WriteLine(password.CheckPassword());
            string text = "gunEL";
            Console.WriteLine(text.Capitalize());
            Console.WriteLine("hgTTTj".Capitalize());
        }
    }
}
