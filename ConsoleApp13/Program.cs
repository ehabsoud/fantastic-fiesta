namespace ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        string lösenord = "";
        
        while (lösenord != "Liverpool")
        {
            Console.WriteLine("Lösenord: ");
            lösenord = Console.ReadLine();

            if (lösenord == "Liverpool")
            {
                Console.WriteLine("Välkommen");
            }
            else
            {
                Console.WriteLine("Försök igen");
            }
        }

    }
}


        




































