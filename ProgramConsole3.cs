namespace Console3.ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring an int operation variable
            int operation = 4 + 10 * 5;
            //multiplication comes first in arithmetic calculation than addition
            Console.WriteLine("Result is= " + operation);

            //updating int operation variable
            operation = (4 + 10) * 5;
            //parantheses comes first in arithmetic calculation than multiplication
            Console.WriteLine("Result is= " + operation);

            //declaring and dividing an int dividingIntegers, dividingFloats and dividingDoubles variable
            int dividingIntegers = 25 / 2;
            float dividingFloats = 25 / 2;
            double dividingDoubles = 25 / 2;

            //printing the wrong results on console
            Console.WriteLine("Result of integer divide (wrong): " + dividingIntegers);
            Console.WriteLine("Result of float divide (wrong): " + dividingFloats);
            Console.WriteLine("Result of double divide (wrong): " + dividingDoubles);

            //declaring a double dividingDoublesCorrect variable and do the correct form calculation
            double dividingDoublesCorrect = 25.0 / 2.0;
            //printing the correct arithmetic results on console
            Console.WriteLine("Result of correct float divide: " + dividingDoublesCorrect);

            //declaring a double dividingFloatsCorrect variable and do the correct form calculation
            float dividingFloatsCorrect = 25f / 2;
            //printing the correct arithmetic results on console
            Console.WriteLine("Result of correct float divide: " + dividingFloatsCorrect);

            //declaring an int modulo variable and printing the result on console
            int modulo = 33 % 6;
            Console.WriteLine("Remainder of the modulo operation is: " + modulo);

            //declaring an int x variable
            int x = 0;
            Console.WriteLine("X initial value is: " + x);
            //x++ means x + 1
            x++;
            //printing the result on console
            Console.WriteLine("X value after x++ is: " + x);
            //updating x value as 0 again
            x = 0;
            //printing the update on console
            Console.WriteLine("X value is updated back to " + x);
            //x-- means x + 1
            x--;
            //printing the result on console
            Console.WriteLine("X value after x-- is: " + x);
        }
    }
}
