namespace Generics_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Maximum Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //Console.WriteLine(output);

            //double doubleoutput = MaximumFloatCheck.MaximumFloatNumber(11.22, 44.33, 33.44);
            //Console.WriteLine(doubleoutput);

            //string stringoutput = MaximumStringCheck.MaximumString("Ram", "Prabu", "Revanth");
            //Console.WriteLine(stringoutput);

            int[] arr = { 112, 344, 432, 555, 678 };
            GenericMaximumNumber<int> generic = new GenericMaximumNumber<int>(arr);
            generic.PrintMaxValue();
            
            double[] doublearray = { 11.2, 34.4, 43.2, 55.5, 67.8 };
            GenericMaximumNumber<double> genericDouble = new GenericMaximumNumber<double>(doublearray);
            genericDouble.PrintMaxValue();

        }
    }
}