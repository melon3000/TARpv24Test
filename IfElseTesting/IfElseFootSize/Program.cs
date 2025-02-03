using System;

class Program
{
    static void Main(string[] args) 
    {
        // Küsi kasutajalt jalanumbri sisestamist
        Console.Write("Sisesta oma jalanumber: ");
        int jalanumber = int.Parse(Console.ReadLine());

        // Kontrolli jalanumbri järgi tingimusi
        if (jalanumber >= 30 && jalanumber <= 33)
        {
            // Kui jalanumber on vahemikus 30-33, siis muutub tekst roheline
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sinu jalanumber on {jalanumber}.");
        }
        else if (jalanumber >= 34 && jalanumber <= 38)
        {
            // Kui jalanumber on vahemikus 34-38, siis taust muutub valgeks
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Sinu jalanumber on {jalanumber}.");
        }
        else if (jalanumber >= 39 && jalanumber <= 44)
        {
            // Kui jalanumber on vahemikus 39-44, siis tekst on sinine ja taust kollane
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Sinu jalanumber on {jalanumber}.");
        }
        else if (jalanumber >= 45 && jalanumber <= 48)
        {
            // Kui jalanumber on vahemikus 45-48, teeb arvuti häält (beep)
            Console.Beep();
            Console.WriteLine($"Sinu jalanumber on {jalanumber}.");
        }
        else
        {
            // Kui jalanumber ei ole üheski eelnevas vahemikus
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sinu jalanumber on {jalanumber}.");
        }

        // Lõpuks tagasta värv tagasi normaalseks
        Console.ResetColor();
    }
}
