namespace IfElseColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
                "kontrollitakse stringi abil värvi vastavust");
            Console.WriteLine("Värvide valikuks on: red, blue, green ja white");
            Console.WriteLine("Sisestage värv:");

            // küsi kasutajalt
            string colorInput = Console.ReadLine().ToLower(); 


            if (colorInput == "red" || colorInput == "blue" || colorInput == "green" || colorInput == "white")
            {
                Console.WriteLine($"Valisite värvi: {colorInput}");
            }
            else
            {
                // Handle invalid color input
                Console.WriteLine("Vigane värv. Palun sisestage üks järgmistest värvidest: red, blue, green või white.");
            }
        }
    }
}
