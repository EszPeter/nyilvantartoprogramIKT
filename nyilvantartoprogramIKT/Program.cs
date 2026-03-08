using System.Reflection.Metadata.Ecma335;

namespace nyilvantartoprogramIKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuValaszt = false;
            while (!menuValaszt)
            {
                Console.WriteLine("----------Üdvözlünk a menüben!----------");
                Console.WriteLine($"\t1, Menü");
                Console.WriteLine($"\t2, Menü");
                Console.WriteLine($"\t3, Menü");
                Console.WriteLine("----------------------------------------");
                ConsoleKeyInfo kivalasztottBillentyu = Console.ReadKey(true);
                char lenyomottBillentyu = kivalasztottBillentyu.KeyChar;
                switch (lenyomottBillentyu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Menü 1,");
                        menuValaszt = true;
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Menü 2,");
                        menuValaszt = true;
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Menü 3,");
                        menuValaszt = true;
                        break;
                    default:
                        Console.WriteLine("Kérjük válasszon a fenti számokból!");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
