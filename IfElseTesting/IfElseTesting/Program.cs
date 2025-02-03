namespace IfElseTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");
            
            int number = 201;

            //Kontrollitakse kas arv on suurem 189-st
            if (number > 189)
            {
                //kui vastab if tingimustele 
                Console.WriteLine("Number is bigger");

                //if ja else Nestimine 
                if (number >= 190 && number < 200)
                    Console.WriteLine("Number is between 190 to 200");
                
                else
                {
                    Console.WriteLine("Number is bigger than 200");
                }
            }
            else
            {
                Console.WriteLine("Number is smaller");
            }

        }
    }
}
