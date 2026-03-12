using System.Reflection.Metadata.Ecma335;

namespace nyilvantartoprogramIKT
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //StreamReader sr = new StreamReader("Adatlap.txt");
            bool menuValaszt = false;
            Console.WriteLine("Kérjük válasszon a lenti Menüpontokból!");
            Console.WriteLine("----------Üdvözlünk a PC szervizünk nyilvántartó programjában!----------");
            Console.WriteLine($"1, Új munkalap létrehozása");
            Console.WriteLine($"2, Meglévő munkalap módosítása");
            Console.WriteLine($"3, Meglévő munkalapok listázása");
            Console.WriteLine($"4, Meglévő munkalap törlése");
            Console.WriteLine($"5, Mentés és kilépés");
            Console.WriteLine("------------------------------------------------------------------------");
            List<Munkalap> ideiglenesMunkalapok = new List<Munkalap>();
            while (!menuValaszt)
            {
                ConsoleKeyInfo kivalasztottBillentyu = Console.ReadKey(true);
                char lenyomottBillentyu = kivalasztottBillentyu.KeyChar;
                switch (lenyomottBillentyu)
                {
                    case '1':
                       
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("2, Meglévő munkalap módosítása");

                        // Lista megjelenítése, hogy tudjuk mit módosítunk
                        for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ideiglenesMunkalapok[i].EszkozNev}");
                        }


                            Console.Write("\nAdja meg a módosítandó munkalap sorszámát: ");
                            int sorszam = Convert.ToInt32(Console.ReadLine());
                            int index = sorszam - 1;

                            if (index >= 0 && index < ideiglenesMunkalapok.Count)
                            {
                                Console.WriteLine("1 - Alkatrész ár módosítása");
                                Console.WriteLine("2 - Munkadíj módosítása");
                                string valasztas = Console.ReadLine();

                                if (valasztas == "1")
                                {
                                    Console.Write("Új ár: ");
                                    int ujAr = Convert.ToInt32(Console.ReadLine());
                                    ideiglenesMunkalapok[index].SetAlkatreszekAra(ujAr);
                                }
                                else if (valasztas == "2")
                                {
                                    Console.Write("Új munkadíj: ");
                                    int ujMunkadij = Convert.ToInt32(Console.ReadLine());
                                    ideiglenesMunkalapok[index].SetMunkadij(ujMunkadij);
                                }
                                Console.WriteLine("Sikeres módosítás!");
                            }
                            else
                            {
                                Console.WriteLine("Nincs ilyen sorszámú munkalap!");
                            }
                        

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
                        //sr.Close();
                        menuValaszt = true;
                        break;
                    default:

                        Console.WriteLine("Kérjük válasszon a fenti számokból!");

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

