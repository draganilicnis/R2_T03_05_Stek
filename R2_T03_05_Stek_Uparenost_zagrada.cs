// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/uparenost_zagrada
using System;
using System.Collections.Generic;

class R2_T03_05_Stek_Uparenost_zagrada
{
    static void Main()
    {
        string s = Console.ReadLine();                  // ULAZ: Izraz: [3*(2+4)]*5
        var a = new Stack<char>();                      // Stek (magacin)
        bool bIspravan = true;                          // Ispravan?

        foreach (char c in s)                           // Za svako slovo u izrazu
        {
            if (c == '(' || c == '[' || c == '{')       // Ako slovo bilo koja otvorena zagrada
                a.Push(c);                              // Dodajemo tu otvorenu zagradu na stek
            else if (c == ')' || c == ']' || c == '}')  // Ako slovo bilo koja zatvorena zagrada
            {
                if (a.Count == 0)                       // i ako je stek prazan, to znaci
                {
                    bIspravan = false;                  // da zatvorena zagrada nema otvorenu, pa je izraz neispravan
                    break;
                }
                char otvorena = a.Pop();                // uzimamo vrednost poslednje dodate otvorene zagrade sa steka
                if ((c == ')' && otvorena != '(') || (c == ']' && otvorena != '[') || (c == '}' && otvorena != '{'))
                {
                    bIspravan = false;                  // zatvorena zagrada nema odgovarajucu otvorenu, pa je izraz neispravan
                    break;
                }
            }
        }
        
        if (a.Count > 0) bIspravan = false;             // Ako magacin nije prazan, odnosno ako je ostala bilo koja otvorena zagrada => izraz je neispravan
        Console.WriteLine(bIspravan ? "da" : "ne");     // IZLAZ
    }
}
