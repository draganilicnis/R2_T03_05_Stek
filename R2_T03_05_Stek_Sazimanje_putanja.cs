// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/sazimanje_putanja
using System;
using System.Collections.Generic;

class R2_T03_05_Stek_Sazimanje_putanja
{
    static void Main()
    {
        string sPutanja = Console.ReadLine();       // ULAZ: Putanja
        string[] s = sPutanja.Split('/');           // Razdvajanje stringa Putanja (sa ulaza) na delove (niz stringova)
        var a = new Stack<string>();                // Stek (magacin)

        foreach (string x in s)                     // Za svaki element (deo putanje)
        {
            if (x == "." || x == "")                // Ako je ".", odnosno tekuci folder, onda ne nista ne menjamo
                continue;
            else if (x == "..")                     // Ako je "..", odnosno roditeljski folder, onda iz steka izbacujemo folder sa vrha steka (poslednji dodati folder)
            {
                if (a.Count > 0) a.Pop();           // Pod uslovom da stek nije prazan
            }
            else                                    // Dodajemo folder na stek
                a.Push(x);
        }

        string[] sRezultat = a.ToArray();
        Array.Reverse(sRezultat);

        Console.Write("/");
        Console.WriteLine(string.Join("/", sRezultat));
    }
}
