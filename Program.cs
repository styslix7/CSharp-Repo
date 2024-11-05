namespace Console2.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //signed integer value from -2,147,483,648 to 2,147,483,647
            int countriesInWorld = 196;

            //signed the highest value and integer can take
            int biggestNumber = 2147483647;

            //signed a pi float using "f" suffix
            float pi = 3.1415f;

            //printing without placeholder, using CRLF
            Console.Write("Pi is= ");
            Console.WriteLine(pi);

            //alternative printing with the use of placeholder, {0...}
            Console.WriteLine("Pi value is= {0}", pi);
        }
    }
}
