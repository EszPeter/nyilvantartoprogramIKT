using System.Reflection.Metadata.Ecma335;

namespace nyilvantartoprogramIKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asd");
            ConsoleKeyInfo kivalasztottBillentyu= Console.ReadKey(true);
            char lenyomottBillentyu = kivalasztottBillentyu.KeyChar;
            switch (lenyomottBillentyu)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Menü 1,");
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Menü 2,");
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Menü 3,");
                    break;

                default:
                    Console.WriteLine("Kérjük válasszon a fenti számokból!");
                    break;
            }
            
        }
    }
}
