using System;
using System.Text;                                  // Zbog StringBuiler-a
using System.Collections.Generic;
class R2_T03_05_Stek_Linijski_editor_Ver_00_Bez_steka_LinkedList_Char       // O(N)
{
    static void Main()
    {
        var sUlaz = Console.ReadLine();             // ULAZ: iaib<bic>> ILI izidiriaivio<<<<<dbib<<<i!>>>>>i.
        var a = new LinkedList<Char>();             // Lista karaktera
        var p = a.First;                            // p: Prvi element (cvor) liste karaktera
        int i = 0;                                  // i: Pozicija karaktera u ulaznoj recenici (naredbi)
        // var s = new StringBuilder();                // s: Rezultat: Linija teksta
        int n = sUlaz.Length;                       // n: Duzina ulaznog teksta (recenice, naredbi)
        while (i < n)                               // Sve dok ima karaktera u ulaznoj recenici (dok ne dodjemo do poslednjeg karaktera). Da li bi mogla for petlja?
        {
            char c = sUlaz[i];                          // c: Tekuci karakter (naredba)
            if (c == '<')
            {
                if (p != null) p = p.Previous;          // Ako je naredba za pomeranje kursora LEVO
            }
            else if (c == '>')                          // Ako je naredba za pomeranje kursora DESNO
            {
                if (p == null) p = a.First;             
                else if (p.Next != null) p = p.Next;
            }
            else if (c == 'i')                          // Ako je naredba za umetanje sledeceg slova
            {
                if (p == null)
                {
                    i++;                                // Pomeramo se na sledecu (desno) poziciju karaktera (iza slova i)
                    a.AddFirst(sUlaz[i]);
                    p = a.First;
                }
                else
                {
                    i++;                                // Pomeramo se na sledecu (desno) poziciju karaktera (iza slova i)
                    a.AddAfter(p, sUlaz[i]);
                    p = p.Next;
                }
            }
            else if (c == 'b' && p != null)             // Ako je naredba za brisanje karaktera iza kursora
            {
                var prethodni = p.Previous;             // Priprema za brisanje 1 karaktera na poziciji p ispred kursora i pomeranje kursora p levo
                a.Remove(p);                            // Brisanje 1 karaktera na poziciji p
                p = prethodni;
            }
            else if (c == 'd')                          // Ako je naredba za brisanje karaktera ispred kursora
            {
                if (p == null)
                {
                    if (a.Count > 0) a.RemoveFirst();
                }
                else if (p.Next != null) a.Remove(p.Next);  // Brisanje 1 karaktera na poziciji p kursora
            }
            i++;                                    // Pozicija sledeceg karaktera (desno)
        }
        // Console.WriteLine(s);                       // IZLAZ: cb ILI !bravo.
        var char_niz = new char[a.Count];
        a.CopyTo(char_niz, 0);
        string sRezulat = new string(char_niz);
        Console.WriteLine(sRezulat);
    }
}
