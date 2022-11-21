namespace RegexAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PostalNumber postalNumber = new PostalNumber();
            postalNumber.ValidatePinCode("415 311");
        }
    }
}