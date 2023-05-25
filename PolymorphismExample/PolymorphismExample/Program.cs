namespace PolymorphismExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            World unitedStates = new UnitedStates();
            World canada = new Canada();
            World britain = new Britain();

            unitedStates.TypeOfCurrency();
            canada.TypeOfCurrency();
            britain.TypeOfCurrency();

        }
    }
}