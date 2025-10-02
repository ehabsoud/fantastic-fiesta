namespace ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        string lösenord = "";
        int försök = 0;
        int maxFörsök = 3;
        
        while (försök < maxFörsök)
        {
            
            Console.WriteLine("Lösenord: ");
            lösenord = Console.ReadLine();
            försök++;

            if (lösenord == "Liverpool")
            {
                Console.WriteLine("Välkommen!");
                break;
            }
            else
            {
                if (försök < maxFörsök)
                {
                    Console.WriteLine($"Försök igen, {maxFörsök - försök} kvar");
                }
                else
                {
                    Console.WriteLine("Fel lösenord, inga försök kvar, försök igen om 5 minuter");
                }
            }
        }

    }
}


        




































