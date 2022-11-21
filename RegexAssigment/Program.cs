namespace RegexAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PostalNumber postalNumber = new PostalNumber();
            Console.WriteLine(postalNumber.validatePinCode("415311"));
        }
    }
}