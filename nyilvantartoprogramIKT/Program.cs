using System.Reflection.Metadata.Ecma335;

namespace nyilvantartoprogramIKT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Adatlap.txt");
            bool menuValaszt = false;
            Console.WriteLine("Kérjük válasszon a lenti Menüpontokból!");
            Console.WriteLine("----------Üdvözlünk a PC szervizünk nyilvántartó programjában!----------");
            Console.WriteLine($"1, Új munkalap létrehozása");
            Console.WriteLine($"2, Meglévő munkalap módosítása");
            Console.WriteLine($"3, Meglévő munkalapok listázása");
            Console.WriteLine($"4, Meglévő munkalap törlése");
            Console.WriteLine($"5, Mentés és kilépés");
            Console.WriteLine("------------------------------------------------------------------------");
            while (!menuValaszt)
            {
                ConsoleKeyInfo kivalasztottBillentyu = Console.ReadKey(true);
                char lenyomottBillentyu = kivalasztottBillentyu.KeyChar;
                switch (lenyomottBillentyu)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("1, Új munkalap létrehozása");

                        Console.WriteLine("Nyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("2, Meglévő munkalap módosítása");

                        Console.WriteLine("Nyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("3, Meglévő munkalapok listázása");

                        Console.WriteLine("Nyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("4, Meglévő munkalap törlése");

                        Console.WriteLine("Nyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Mentés és kilépés");
                        sr.Close();
                        menuValaszt = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"\n----------Üdvözlünk a PC szervizünk nyilvántartó programjában!----------");
                        Console.WriteLine($"1, Új munkalap létrehozása");
                        Console.WriteLine($"2, Meglévő munkalap módosítása");
                        Console.WriteLine($"3, Meglévő munkalapok listázása");
                        Console.WriteLine($"4, Meglévő munkalap törlése");
                        Console.WriteLine($"5, Mentés és kilépés");
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("Kérjük válasszon a fenti Menüpontokból!");
                        break;
                }
            }
        }
    }
}
