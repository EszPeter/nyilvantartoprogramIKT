using System.Reflection.Metadata.Ecma335;

namespace nyilvantartoprogramIKT
{
    internal class Program
    {
        static void Main(string[] args)
        {



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
                        Console.Clear();
                        bool befejeztedE = false;
                        while (!befejeztedE)
                        {
                            Console.WriteLine("1, Új munkalap létrehozása");


                            Console.Write("Kérem adja meg az eszköz nevét: ");
                            string eszkozNev = Console.ReadLine();

                            Console.Write("Kérem adja meg az eszköz hibaleírását:");
                            string hibaLeiras = Console.ReadLine();

                            int alkatreszekAra = 0, munkadij = 0;

                            bool szamTipusE = false;
                            bool szamTipusE2 = false;

                            while (!szamTipusE)
                            {
                                try
                                {

                                    Console.Write("\nKérem adja meg az alkatrészek együttes összegét!");
                                    alkatreszekAra = Convert.ToInt32(Console.ReadLine());
                                    while (alkatreszekAra < 0)
                                    {
                                        Console.Write("\nHibás bemenet! Pozitív számot adjon meg!");
                                        alkatreszekAra = Convert.ToInt32(Console.ReadLine());
                                    }
                                    szamTipusE = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Hibás bemenet! Számot adjon meg!");
                                }
                            }
                            while (!szamTipusE2)
                            {
                                try
                                {
                                    Console.Write("\nKérem adja meg a munkadíj összegét!");
                                    munkadij = Convert.ToInt32(Console.ReadLine());
                                    while (munkadij < 0)
                                    {
                                        Console.Write("\nHibás bemenet! Pozitív számot adjon meg!");
                                        munkadij = Convert.ToInt32(Console.ReadLine());
                                    }
                                    szamTipusE2 = true;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Hibás bemenet! Számot adjon meg!");
                                }
                            }


                            Munkalap ujMunkalap = new Munkalap(eszkozNev, hibaLeiras, alkatreszekAra, munkadij);
                            ideiglenesMunkalapok.Add(ujMunkalap);

                            Console.Write("Szeretne még egy munkalapot létrehozni? (i/n) ");
                            string valasz = Console.ReadLine();
                            if (valasz == "i")
                            {
                                continue;
                            }
                            else if (valasz == "n")
                            {
                                befejeztedE = true;
                            }
                            else
                            {
                                Console.WriteLine("Kérem válasszon a két lehetőség közül!");
                                Console.WriteLine("Szeretne még egy munkalapot létrehozni? (i/n)");
                                valasz = Console.ReadLine();
                                while (valasz != "i" && valasz != "n")
                                {
                                    Console.WriteLine("Kérem válasszon a két lehetőség közül!");
                                    Console.WriteLine("Szeretne még egy munkalapot létrehozni? (i/n)");
                                    valasz = Console.ReadLine();
                                }
                                if (valasz == "i")
                                {
                                    continue;
                                }
                                else if (valasz == "n")
                                {
                                    befejeztedE = true;
                                }
                            }

                        }
                        using (StreamWriter sw = new StreamWriter("munkalapok.txt", false))
                        {
                            for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                            {
                                sw.WriteLine($"{ideiglenesMunkalapok[i].EszkozNev};{ideiglenesMunkalapok[i].HibaLeiras};{ideiglenesMunkalapok[i].AlkatreszekAra};{ideiglenesMunkalapok[i].Munkadij};{ideiglenesMunkalapok[i].Statusz}");
                            }
                        }

                        Console.WriteLine("\nNyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("2, Meglévő munkalap módosítása");

                        // Lista megjelenítése, hogy tudjuk mit módosítunk
                        for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ideiglenesMunkalapok[i].EszkozNev}");
                        }

                        bool amigNemSzam = false;
                        while (!amigNemSzam)
                        {
                            try
                            {
                                Console.Write("\nAdja meg a módosítandó munkalap sorszámát: ");
                                int sorszam = Convert.ToInt32(Console.ReadLine());
                                int index = sorszam - 1;

                                if (index >= 0 && index < ideiglenesMunkalapok.Count)
                                {
                                    Console.WriteLine("1 - Alkatrész ár módosítása");
                                    Console.WriteLine("2 - Munkadíj módosítása");
                                    Console.WriteLine("3 - Státuszváltoztatás: folyamatban");
                                    Console.WriteLine("4 - Státuszváltoztatás: befejezve");
                                    Console.WriteLine("5 - Státuszváltoztatás: aktuális");

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
                                    else if (valasztas == "3")
                                    {
                                        ideiglenesMunkalapok[index].MunkaFolyamatban();
                                    }
                                    else if (valasztas == "4")
                                    {
                                        ideiglenesMunkalapok[index].MunkaElvégezve();
                                    }
                                    else if (valasztas == "5")
                                    {
                                        ideiglenesMunkalapok[index].MunkaAktualis();
                                    }
                                    Console.WriteLine("Sikeres módosítás!");
                                    using (StreamWriter sw = new StreamWriter("munkalapok.txt", false))
                                    {
                                        for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                                        {
                                            sw.WriteLine($"{ideiglenesMunkalapok[i].EszkozNev};{ideiglenesMunkalapok[i].HibaLeiras};{ideiglenesMunkalapok[i].AlkatreszekAra};{ideiglenesMunkalapok[i].Munkadij};{ideiglenesMunkalapok[i].Statusz}");
                                        }
                                    }
                                    amigNemSzam = true;
                                }
                                else
                                {
                                    Console.WriteLine("Nincs ilyen sorszámú munkalap!");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Hiba! Kérjük számot adjon meg!");
                            }
                        }
                        Console.WriteLine("\nNyomjon meg egy gombot a menübe való visszatéréshez!");
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("3, Meglévő munkalapok listázása");

                        Console.WriteLine("Nyomjon meg bármilyen gombot a kilépéshez!");
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("4, Meglévő munkalap törlése");

                        for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ideiglenesMunkalapok[i]}");
                        }


                        try
                        {
                            Console.Write("\nAdja meg a törlendő munkalap sorszámát: ");
                            int torlesSorszam = Convert.ToInt32(Console.ReadLine());
                            int torlesIndex = torlesSorszam - 1;

                            if (torlesIndex >= 0 && torlesIndex < ideiglenesMunkalapok.Count)
                            {
                                ideiglenesMunkalapok.RemoveAt(torlesIndex);
                                Console.WriteLine("Munkalap sikeresen törölve!");
                            }
                            else
                            {
                                Console.WriteLine("Érvénytelen sorszám!");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Hiba történt! Csak számot adhat meg a sorszámhoz!");
                        }
                        Console.WriteLine("\nNyomjon meg egy gombot a menübe való visszatéréshez!");
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("Mentés és kilépés");
                        menuValaszt = true;

                        Console.WriteLine("Szeretné-e menteni a munkáját? (i/n) ");
                        string mentiE = Console.ReadLine();

                        while (mentiE != "i" || mentiE != "n")
                        {
                            if (mentiE == "i")
                            {
                                StreamWriter sw = new StreamWriter("munkalapok.txt");
                                for (int i = 0; i < ideiglenesMunkalapok.Count; i++)
                                {
                                    sw.WriteLine(ideiglenesMunkalapok[i]);
                                }
                                sw.Close();
                                ideiglenesMunkalapok.Clear();
                                break;
                            }
                            else if (mentiE == "n")
                            {
                                ideiglenesMunkalapok.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kérem válasszon a két lehetőség közül!");
                                Console.Write("Szeretné-e menteni a munkáját? (i/n) ");
                                mentiE = Console.ReadLine();
                            }
                        }
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

