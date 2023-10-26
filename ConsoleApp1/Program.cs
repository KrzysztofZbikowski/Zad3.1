class Zad
{
    static void Main(string[] args)
    {
        int rok;
        Console.WriteLine("Podaj rok: ");
        rok = int.Parse(Console.ReadLine());
        if(rok%4==0)
        {
            if(rok%100!=0)
            {
                Console.WriteLine("Jest to rok przestępny");
            }
            else if (rok%400==0)
            {
                Console.WriteLine("Jest to rok przestępny");
            }
            else
            {
                Console.WriteLine("Nie jest to rok przestępny");
            }
        }
        else
        {
            Console.WriteLine("Nie jest to rok przestępny");
        }
        Console.ReadKey();
    }
}