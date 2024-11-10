namespace Console4.CharactersAndHexadecimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char stands for character which you need to put '' instead of "" to declare since it only takes 1 single space and is not a string.
            char myFirstInitial = 'B';
            char myLastInitial = 'P';

            //"b" below stands for backspace which moves the cursor one position backwards and "t" is for tab which moves the cursor to next tab.
            char backSpace = '\b';
            char tab = '\t';

            //u0062 is the hexadecimal value for "b", which prints "b"
            char hexLetter = '\u0062';

            //printings all of them to console with using \" which stands for " itself.
            Console.WriteLine("\"My first initial= " + myFirstInitial + "\t" + "Last initial= " + myLastInitial + "\"");
            Console.WriteLine("My first initial in hexadecimal value= " + hexLetter);
        }
    }
}
