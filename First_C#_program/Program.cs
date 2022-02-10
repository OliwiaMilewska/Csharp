using System;
using System.IO;
using System.Text;

namespace ProjektOM
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = 0, s2 = 0, s3 = 0, s4 = 0; //szerkosc scian
            double w1 = 0, w2 = 0, w3 = 0, w4 = 0; //wyskosc scian
            string odp1 = "", odp2 = "", odp3 = "", odp4 = "", odp5 = "", odp6 = "", odp7 = "", odp8 = "";
            double sciany = 0, listwy = 0, sd = 0, wd = 0, wysokoscPaska = 0, suf1 = 0, suf2 = 0, kolor1, kolor2 = 0, wydajnosc = 0, podklad = 0, litry = 0;
            double odejmnik1 = 0, odejmnik2 = 0, odejmnik3 = 0, odejmnik4 = 0, odejmnik5 = 0, dodatek = 0;
            int iloscOkien = -1, i, iloscGniazdek = -1;
            StringBuilder notatnik = new StringBuilder();
            Console.WriteLine("Cześć");
            Console.WriteLine("Z moją pomocą uda Ci się oszacować ile litrów farby musisz kupić, do pomalowania swojego wymarzonego pokoju! :D");
            Console.WriteLine("Nie traćmy czasu i bierzmy się do roboty!");
            Console.WriteLine("");
            WczytajWymiar(ref s1, ref w1, 1); //wczytywanie wymiarów ścian
            WczytajWymiar(ref s2, ref w2, 2);
            WczytajWymiar(ref s3, ref w3, 3);
            WczytajWymiar(ref s4, ref w4, 4);
            sciany = s1 * w1 + s2 * w2 + s3 * w3 + s4 * w4; //pole powierzchni ścian
            while (odp1 != "tak" && odp1 != "TAK" && odp1 != "Tak" && odp1 != "tAk" && odp1 != "taK" && odp1 != "TAk" && odp1 != "tAK" && odp1 != "TaK" &&
                odp1 != "nie" && odp1 != "NIE" && odp1 != "Nie" && odp1 != "nIE" && odp1 != "niE" && odp1 != "NIe" && odp1 != "nIE" && odp1 != "NiE")
            {
                Console.WriteLine("> Masz lub planujesz mieć w pokoju listwy przypodłogowe? (tak/nie)");
                odp1 = Console.ReadLine();
            };
            if (odp1.ToUpper() == "TAK")
            {
                Console.WriteLine("> Podaj mi ich wysokość (w metrach)?");
                while (listwy == 0)
                {
                    try
                    {
                        listwy = Convert.ToDouble(Console.ReadLine());
                        odejmnik1 = listwy * (s1 + s2 + s3 + s4);
                    }
                    catch
                    {
                        Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                    }
                }
            };
            while (iloscOkien == -1)
            {
                try
                {
                    Console.WriteLine("> Ile masz okien w pokoju?");
                    iloscOkien = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Podaj mi ich liczbę. *");
                }
            };
            double[] oknaSz = new double[iloscOkien]; //tablica przechowuje szerokosci okien
            double[] oknaW = new double[iloscOkien]; //tablica przechowuje wysokosci okien
            for (i = 0; i < iloscOkien; i++) //wczytuje wymiary okien
            {
                while (oknaSz[i] == 0)
                {
                    try
                    {
                        Console.WriteLine("> Podaj szerokość " + (i + 1) + " okna w metrach:");
                        oknaSz[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                    }
                };
                while (oknaW[i] == 0)
                {
                    try
                    {
                        Console.WriteLine("> Podaj wysokosc " + (i + 1) + " okna w metrach:");
                        oknaW[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                    }
                };
            };
            for (i = 0; i < iloscOkien; i++) //liczy wartosc odejmnik2
            {
                odejmnik2 += oknaSz[i] * oknaW[i];
            }
            while (iloscGniazdek == -1)
            {
                try
                {
                    Console.WriteLine("> Ile posiadasz gniazdek?");
                    iloscGniazdek = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Policz na paluszkach i podaj mi ich liczbę! :) *");
                }
            };
            odejmnik3 = iloscGniazdek * Math.Pow(0.082, 2); //0.082m x 0.082m wymiary zwykłego gniazdka
            while (sd == 0) //sd= szerokosc drzwi 
            {
                try
                {
                    Console.WriteLine("> Podaj szerokość drzwi wraz z ramą w metrach:");
                    sd = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
            while (wd == 0) //wd= wyskosc drzwi
            {
                try
                {
                    Console.WriteLine("> Podaj wysokośc drzwi wraz z ramą w metrach:");
                    wd = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
            odejmnik4 = sd * wd;
            while (odp2 != "tak" && odp2 != "TAK" && odp2 != "Tak" && odp2 != "tAk" && odp2 != "taK" && odp2 != "TAk" && odp2 != "tAK" && odp2 != "TaK" &&
                odp2 != "nie" && odp2 != "NIE" && odp2 != "Nie" && odp2 != "nIE" && odp2 != "niE" && odp2 != "NIe" && odp2 != "nIE" && odp2 != "NiE")
            {
                Console.WriteLine("> Czy zamierzasz malować sufit? (tak/nie)");
                odp2 = Console.ReadLine();
            };
            if (odp2.ToUpper() == "NIE")
            {
                while (odp3 != "tak" && odp3 != "TAK" && odp3 != "Tak" && odp3 != "tAk" && odp3 != "taK" && odp3 != "TAk" && odp3 != "tAK" && odp3 != "TaK" &&
                odp3 != "nie" && odp3 != "NIE" && odp3 != "Nie" && odp3 != "nIE" && odp3 != "niE" && odp3 != "NIe" && odp3 != "nIE" && odp3 != "NiE")
                {
                    Console.WriteLine("> Życzysz sobie, aby przy suficie było odcięcie w jego kolorze? (tak / nie)");
                    odp3 = Console.ReadLine();
                };
                odp3.ToUpper();
                if (odp3.ToUpper() == "TAK")
                {
                    while (wysokoscPaska == 0)
                    {
                        try
                        {
                            Console.WriteLine("> Jak wysokie chciałbyś/chciałabyś aby było (w metrach)?");
                            wysokoscPaska = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                        }
                    };
                    odejmnik5 = wysokoscPaska * (s1 + s2 + s3 + s4);
                };
            };
            if (odp2.ToUpper() == "TAK")
            {
                while (suf1 == 0)
                {
                    try
                    {
                        Console.WriteLine("> Podaj pierwszy wymiar sufitu:");
                        suf1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                    }
                };
                while (suf2 == 0)
                {
                    try
                    {
                        Console.WriteLine("> Podaj drugi wymiar sufitu:");
                        suf2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                    }
                };
                while (odp4 != "tak" && odp4 != "TAK" && odp4 != "Tak" && odp4 != "tAk" && odp4 != "taK" && odp4 != "TAk" && odp4 != "tAK" && odp4 != "TaK" &&
                odp4 != "nie" && odp4 != "NIE" && odp4 != "Nie" && odp4 != "nIE" && odp4 != "niE" && odp4 != "NIe" && odp4 != "nIE" && odp4 != "NiE")
                {
                    Console.WriteLine("> Chcesz aby sufit był w tym samym kolorze? (tak/nie)");
                    odp4 = Console.ReadLine();
                };
                if (odp4.ToUpper() == "TAK")
                {
                    dodatek = suf1 * suf2;
                };
                if (odp4.ToUpper() == "NIE")
                {
                    while (odp5 != "tak" && odp5 != "TAK" && odp5 != "Tak" && odp5 != "tAk" && odp5 != "taK" && odp5 != "TAk" && odp5 != "tAK" && odp5 != "TaK" &&
                    odp5 != "nie" && odp5 != "NIE" && odp5 != "Nie" && odp5 != "nIE" && odp5 != "niE" && odp5 != "NIe" && odp5 != "nIE" && odp5 != "NiE")
                    {
                        Console.WriteLine("> Czy życzysz sobie aby przy suficie było odcięcie w jego kolorze? (tak/nie)");
                        odp5 = Console.ReadLine();
                    };
                    if (odp5.ToUpper() == "TAK")
                    {
                        while (wysokoscPaska == 0)
                        {
                            try
                            {
                                Console.WriteLine("> Jak wysokie chciałbyś/chciałabyś aby było (w metrach)?");
                                wysokoscPaska = Convert.ToDouble(Console.ReadLine());
                                kolor2 = suf1 * suf2 + wysokoscPaska * (s1 + s2 + s3 + s4);
                                sciany -= wysokoscPaska * (s1 + s2 + s3 + s4);
                            }
                            catch
                            {
                                Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                            }
                        }
                    };
                    if (odp5.ToUpper() == "NIE")
                    {
                        kolor2 = suf2 * suf2;
                    };
                };
            };
            Console.WriteLine("");
            Console.WriteLine("Spokojnie!");
            Console.WriteLine("Wiem, że pytań jest dużo, ale muszę wiedzieć wszystko dokładnie.");
            Console.WriteLine("Jak wiemy nie od razu Rzym zbudowano, a my nie chcemy popełnić żadnych błędów :P");
            Console.WriteLine("");
            while (wydajnosc == 0)
            {
                try
                {
                    Console.WriteLine("> Pamiętaj, że każda farba ma na swojej etykiecie podaną wydajność.");
                    Console.WriteLine("Musisz mi ją teraz podać w przeliczeniu na 1 warstwę w [m2/L]:");
                    wydajnosc = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
            kolor1 = sciany - odejmnik1 - odejmnik2 - odejmnik3 - odejmnik4 - odejmnik5 + dodatek; // ostateczna powierzchnia do pomalowania na jeden kolor
            while (odp6 != "tak" && odp6 != "TAK" && odp6 != "Tak" && odp6 != "tAk" && odp6 != "taK" && odp6 != "TAk" && odp6 != "tAK" && odp6 != "TaK" &&
                odp6 != "nie" && odp6 != "NIE" && odp6 != "Nie" && odp6 != "nIE" && odp6 != "niE" && odp6 != "NIe" && odp6 != "nIE" && odp6 != "NiE")
            {
                Console.WriteLine("> Czy zamierzasz malować dwa razy? (tak/nie)");
                Console.WriteLine("W końcu cierpliwością i pracą ludzie się bogacą ^^");
                odp6 = Console.ReadLine();
            };
            if (odp6.ToUpper() == "TAK")
            {
                kolor1 = 2 * kolor1;
                kolor2 = 2 * kolor2;
            };
            while (odp7 != "tak" && odp7 != "TAK" && odp7 != "Tak" && odp7 != "tAk" && odp7 != "taK" && odp7 != "TAk" && odp7 != "tAK" && odp7 != "TaK" &&
                odp7 != "nie" && odp7 != "NIE" && odp7 != "Nie" && odp7 != "nIE" && odp7 != "niE" && odp7 != "NIe" && odp7 != "nIE" && odp7 != "NiE")
            {
                Console.WriteLine("> Czy chciałbyś/chciałabyś użyć bezbarwnego podkładu? (tak/nie)");
                odp7 = Console.ReadLine();
            };
            if (odp7.ToUpper() == "TAK")
            {
                podklad = kolor1 + kolor2;
            };
            while (litry == 0)
            {
                try
                {
                    Console.WriteLine("> Ilu litrowe pojemniki z farbą będziesz kupować?");
                    Console.WriteLine("Wiążę się to z ich dźwiganiem, a przecież kręgosłup ma się tylko jeden!");
                    litry = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
            double podkladL = 0, kolor1L, kolor2L; //będziemy przeliczać z m2 na Litry
            podkladL = podklad / wydajnosc;
            kolor1L = kolor1 / wydajnosc;
            kolor2L = kolor2 / wydajnosc;
            Console.WriteLine(" ");
            Przelicznik(ref podkladL, ref kolor1L, ref kolor2L, ref litry, ref notatnik);
            while (odp8 != "tak" && odp8 != "TAK" && odp8 != "Tak" && odp8 != "tAk" && odp8 != "taK" && odp8 != "TAk" && odp8 != "tAK" && odp8 != "TaK" &&
                odp8 != "nie" && odp8 != "NIE" && odp8 != "Nie" && odp8 != "nIE" && odp8 != "niE" && odp8 != "NIe" && odp8 != "nIE" && odp8 != "NiE")
            {
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("> Chesz mieć powyższe dane, zawsze pod ręką? (tak/nie)");
                Console.WriteLine("Mogę je dla Ciebie zapisać w notatniku, aby się nidzie nie zapodziały i żeby nie liczyć wszystkiego od nowa :)");
                odp8 = Console.ReadLine();
            };
            if (odp8.ToUpper() == "TAK")
            {
                string path = @"rezultatobliczen.txt"; //zapisze się w miejscu z programem .exe
               // string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); <-- nie zadziała bez uprawnień
                StreamWriter sw;
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                }
                else
                {
                    sw = new StreamWriter(path, true);
                }
                sw.Write(notatnik);
                sw.Close();
                Console.WriteLine("* Twoje wyniki zostały zapisane w notatniku! *");
            }
            Console.WriteLine(" ");
            Console.WriteLine("HURRA!");
            Console.WriteLine("W końcu nam się udało!");
            Console.WriteLine("Mam nadzieję, że moja pomoc była przydatna.");
            Console.WriteLine("A teraz do dzieła, nie ma czasu do stracenia! Pędź malować swój pokój! :)");
            Console.WriteLine(" ");
            Console.ReadKey(true);
        }
        static void WczytajWymiar(ref double s, ref double w, int x)
        {
            while (s == 0)
            {
                try
                {
                    Console.WriteLine("> Podaj mi szerokość swojej " + x + " ściany (koniecznie w metrach):");
                    s = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
            while (w == 0)
            {
                try
                {
                    Console.WriteLine("> A teraz podaj mi wysokość Twojej " + x + " ściany (koniecznie w metrach):");
                    w = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("* Błąd, zły foramt wprowadzonej wartości! *");
                }
            };
        }
        static void Przelicznik(ref double p, ref double k1, ref double k2, ref double l, ref StringBuilder not)
        {
            double pod = 0, pojemnikKolor1, pojemnikKolor2;
            pod = Math.Ceiling(p / l);
            pojemnikKolor1 = Math.Ceiling(k1 / l);
            pojemnikKolor2 = Math.Ceiling(k2 / l);
            Console.WriteLine("--------------------->  Wyniki dla pojemników o objętości " + l + "L  <---------------------");
            Console.Write("Do pomalowania swojego pokoju zużyjesz {0:0.##}L jednego koloru", k1);
            if (p > 0)
            {
                Console.Write(", {0:0.##}L podkładu", p);
            }
            if (k2 > 0)
            {
                Console.Write(" oraz {0:0.##}L drugiego koloru.", k2);
            }
            Console.WriteLine(" ");
            Console.Write("Musisz kupić {0:0}", pod);
            if (pod > 5 || pod == 0 || pod<=-5)
            {
                Console.Write(" pojemników z podkładem,");
            }
            if (pod == 1)
            {
                Console.Write(" pojemnik z podkładem,");
            }
            if (pod < 5 && pod >= -5 && pod!=0 && pod!=1)
            {
                Console.Write(" pojemniki z podkładem,");
            }
            Console.Write(" "+pojemnikKolor1);
            if (pojemnikKolor1 > 5 || pojemnikKolor1 <=-5 || pojemnikKolor1 == 0)
            {
                Console.Write(" pojemników z kolorem");
            }
            if (pojemnikKolor1 == 1)
            {
                Console.Write(" pojemnik z kolorem");
            }
            if (pojemnikKolor1 < 5 && pojemnikKolor1 >= -5 && pojemnikKolor1!=1 && pojemnikKolor1 != 0)
            {
                Console.Write(" pojemniki z kolorem");
            }
            if (k2 != 0)
            {
                Console.Write(" i " + pojemnikKolor2);
                if (pojemnikKolor2 > 5 || pojemnikKolor2 <= -5)
                {
                    Console.Write(" pojemników z drugim kolorem, którym pomalujesz sufit.");
                }
                if (pojemnikKolor2 == 1)
                {
                    Console.Write(" pojemnik z drugim kolorem, którym pomalujesz sufit.");
                }
                if (pojemnikKolor2 < 5 && pojemnikKolor2 >= -5 && pojemnikKolor2 != 1 )
                {
                    Console.Write(" pojemniki z drugim kolorem, którym pomalujesz sufit.");
                }
            };
            Console.WriteLine(" ");
            if (pojemnikKolor1 < 0 || pojemnikKolor2 <0 || pod<0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("* Hmmm... musiałeś podać złe wartości, ponieważ wyniki wyszłe ujemne :( *");
                Console.WriteLine("                   * Spróbuj od początku! *");
            };
            ///////////////////////aby umożliwić zapis do pliku
            not.Append("--------------------->  Wyniki dla pojemników o objętości " + l + "L  <---------------------");
            not.AppendLine();
            not.Append("Do pomalowania swojego pokoju zużyjesz " + k1 + "L jednego koloru");
            if (p > 0)
            {
                not.Append(", " + p + "L podkładu");
            }
            if (k2 > 0)
            {
                not.Append(" oraz " + k2 + "L drugiego koloru.");
            }
            not.AppendLine();
            not.Append("> Lista najbliższych zakupów w formie ilości pojemników :)");
            not.AppendLine();
            not.Append("Musisz kupić " + pod);
            if (pod > 5 || pod == 0 || pod <= -5)
            {
                not.Append(" pojemników z podkładem,");
            }
            if (pod == 1)
            {
                not.Append(" pojemnik z podkładem,");
            }
            if (pod < 5 && pod >= -5 && pod != 0 && pod != 1)
            {
                not.Append(" pojemniki z podkładem,");
            }
            not.Append("a " + pojemnikKolor1);
            if (pojemnikKolor1 > 5 || pojemnikKolor1 <= -5 || pojemnikKolor1 == 0)
            {
                not.Append(" pojemników z kolorem");
            }
            if (pojemnikKolor1 == 1)
            {
                not.Append(" pojemnik z kolorem");
            }
            if (pojemnikKolor1 < 5 && pojemnikKolor1 >= -5 && pojemnikKolor1 != 1 && pojemnikKolor1 != 0)
            {
                not.Append(" pojemniki z kolorem");
            }
            if (k2 > 0)
            {
                not.Append(" i " + pojemnikKolor2);
                if (pojemnikKolor2 > 5 || pojemnikKolor2 <= -5)
                {
                    not.Append(" pojemników z drugim kolorem, którym pomalujesz sufit.");
                }
                if (pojemnikKolor2 == 1)
                {
                    not.Append(" pojemnik z drugim kolorem, którym pomalujesz sufit.");
                }
                if (pojemnikKolor2 < 5 && pojemnikKolor2 >= -5 && pojemnikKolor2 != 1)
                {
                    not.Append(" pojemniki z drugim kolorem, którym pomalujesz sufit.");
                }
            };
            not.AppendLine();
            if (pojemnikKolor1 < 0 || pojemnikKolor2 < 0 || pod < 0)
            {
                not.AppendLine();
                not.Append("* Hmmm... musiałeś podać złe wartości, ponieważ wyniki wyszłe ujemne :( *");
                not.Append("                   * Spróbuj od początku! *");
            };
        }
    }
}
