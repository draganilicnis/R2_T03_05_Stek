using System;
using System.Text;                                  // Zbog StringBuiler-a
using System.Collections.Generic;
class R2_T03_05_Stek_Linijski_editor_Ver_00_Bez_steka_LinkedList_Char       // O(N)
{
    static void Main()
    {
        var sUlaz = Console.ReadLine();             // ULAZ: iaib<bic>> ILI izidiriaivio<<<<<dbib<<<i!>>>>>i.
        var a = new LinkedList<char>();             // Lista karaktera (linkovana lista karaktera). U cemu je razlika izmedju Char i char?
        var p = a.First;                            // p: Pozicija kursora => Prvi element (cvor) liste karaktera
        int i = 0;                                  // i: Pozicija karaktera u ulaznoj recenici (naredbi)
        // var s = new StringBuilder();                // s: Rezultat: Linija teksta
        int n = sUlaz.Length;                       // n: Duzina ulaznog teksta (recenice, naredbi)
        while (i < n)                               // Sve dok ima karaktera u ulaznoj recenici (dok ne dodjemo do poslednjeg karaktera). Da li bi mogla for petlja?
        {
            char c = sUlaz[i];                          // c: Tekuci karakter (naredba)
            if (c == '<')                               // Ako je naredba za pomeranje kursora LEVO
            {
                if (p != null) p = p.Previous;          // Pomeranje kursora LEVO (pod uslovom da kursor nije vec bio skroz LEVO na pocetku teksta).
            }
            else if (c == '>')                          // Ako je naredba za pomeranje kursora DESNO
            {
                if (p == null) p = a.First;             // Pomeranje kursora DESNO (pod uslovom da kursor nije na samom pocetku praznog teksta).
                else if (p.Next != null) p = p.Next;    // Pomeranje kursora DESNO (pod uslovom da kursor nije vec bio skroz DESNO na pocetku teksta).
            }
            else if (c == 'i')                          // Ako je naredba za umetanje sledeceg slova
            {
                i++;                                    // Pomeramo se na sledecu (desno) poziciju karaktera (iza slova i)
                char x = sUlaz[i];                      // Uzimamo (prvi desno, sada je to i.-ti, jer smo i u prethodnom redu povecali za 1) karakter iz ulazne reci
                if (p == null)                          // Ako je kursor na pocetku (skroz levo)
                {
                    a.AddFirst(x);                      // Dodajemo karakter x na pocetak teksta (skroz levo)
                    p = a.First;                        // Kursor postavljamo skroz levo na pocetak teksta, odnosno na prvo slovo
                }
                else
                {
                    a.AddAfter(p, x);                   // Dodajemo karakter x odmah iza pozicije kursora
                    p = p.Next;                         // Pomeramo kursor za jedno mesto u desno (na karakter x)
                }
            }
            else if (c == 'b' && p != null)             // Ako je naredba za brisanje karaktera iza kursora
            {
                var prethodni = p.Previous;             // Priprema za brisanje 1 karaktera na poziciji p ispred kursora i pomeranje kursora p levo
                a.Remove(p);                            // Brisanje 1 karaktera na poziciji kursora p
                p = prethodni;                          // Kursor pomeramo na prethodni (levo)
            }
            else if (c == 'd')                          // Ako je naredba za brisanje karaktera ispred kursora
            {
                if (p == null)
                {
                    if (a.Count > 0) a.RemoveFirst();       // Ukoliko je brisanje DESNO, a string je prazan
                }
                else if (p.Next != null) a.Remove(p.Next);  // Brisanje 1 karaktera na poziciji p kursora (tacnije desno od kursora (Next))
            }
            i++;                                        // Pozicija sledeceg karaktera (desno)
        }
        // Console.WriteLine(s);                       // IZLAZ: cb ILI !bravo.
        var char_niz = new char[a.Count];
        a.CopyTo(char_niz, 0);
        string sRezulat = new string(char_niz);
        Console.WriteLine(sRezulat);                    // IZLAZ: cb ILI !bravo.
    }
}


/*
https://arena.petlja.org/sr-Latn-RS/competition/r2-t02-06-stek#tab_134642
Додатни материјали:
StringBuilder: 
https://www.geeksforgeeks.org/c-sharp/stringbuilder-in-c-sharp/
StringBuilder vs String: 
https://www.geeksforgeeks.org/c-sharp/c-sharp-string-vs-stringbuilder/
https://c-sharptutorial.com/csharparticles/difference-between-string-and-StringBuilder-in-csharp
LinkedList:
https://www.geeksforgeeks.org/c-sharp/linked-list-implementation-in-c-sharp/
https://www.geeksforgeeks.org/c-sharp/c-sharp-linkedlist-class/
https://codesignal.com/learn/courses/fundamental-data-structures-linked-lists-in-csharp/lessons/working-with-csharps-linkedlist
Stack:
https://www.geeksforgeeks.org/c-sharp/stack-class-in-c-sharp/
https://c-sharptutorial.com/collection/stack-in-csharp
 */
