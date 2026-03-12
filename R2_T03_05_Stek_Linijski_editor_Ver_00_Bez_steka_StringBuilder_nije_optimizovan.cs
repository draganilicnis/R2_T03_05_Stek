// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/linijski_editor
using System;
using System.Text;
// using System.Collections.Generic;

class R2_T03_05_Stek_Linijski_editor_Ver_00_Bez_steka_StringBuilder_nije_optimizovana   // O(N^2)
{
    static void Main()
    {
        var sUlaz = Console.ReadLine();             // ULAZ: iaib<bic>> ILI izidiriaivio<<<<<dbib<<<i!>>>>>i.
        var p = 0;                                  // p: Pozicija kursrora
        int i = 0;                                  // i: Pozicija karaktera u ulaznoj recenici (naredbi)
        var s = new StringBuilder();                // s: Rezultat: Linija teksta
        int n = sUlaz.Length;                       // n: Duzina ulaznog teksta (recenice, naredbi)
        while (i < n)                               // Sve dok ima karaktera u ulaznoj recenici (dok ne dodjemo do poslednjeg karaktera). Da li bi mogla for petlja?
        {
            char c = sUlaz[i];                      // c: Tekuci karakter (naredba)
            if (c == '<' && p > 0) p--;             // Ako je naredba za pomeranje kursora LEVO
            else if (c == '>' && p < s.Length) p++; // Ako je naredba za pomeranje kursora DESNO
            else if (c == 'i')                      // Ako je naredba za umetanje sledeceg slova
            {
                i++;                                // Pomeramo se na sledecu (desno) poziciju karaktera (iza slova i)
                s.Insert(p, sUlaz[i]);              // Dodajemo karakter sa pozicije i ulaznog stringa (koji je odmah desno iza slova i) na poziciju p izlaznog stringa
                p++;                                // Pomeramo poziciju kursora desno
            }
            else if (c == 'b' && p > 0)             // Ako je naredba za brisanje karaktera iza kursora
            {
                p--;                                // Priprema za brisanje 1 karaktera na poziciji p ispred kursora i pomeranje kursora p levo
                s.Remove(p, 1);                     // Brisanje 1 karaktera na poziciji p
            }
            else if (c == 'd' && p < s.Length)      // Ako je naredba za brisanje karaktera ispred kursora
            {
                s.Remove(p, 1);                     // Brisanje 1 karaktera na poziciji p kursora
            }
            i++;                                    // Pozicija sledeceg karaktera (desno)
        }
        Console.WriteLine(s);                       // IZLAZ: cb ILI !bravo.
    }
}
