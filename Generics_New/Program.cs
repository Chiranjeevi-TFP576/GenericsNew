namespace Generics_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum Float Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //Console.WriteLine(output);
            double doubleoutput = MaximumFloatCheck.MaximumFloatNumber(11.22, 22.33, 33.44);
            Console.WriteLine(doubleoutput);

        }
    }
}