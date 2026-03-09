using System;
using System.Collections.Generic;
class R2_T03_05_Stek_Istorija_Veb_pregledaca
{
    static void Main()
    {
        var a = new Stack<string>();                // Stek (magacin)
        var s = Console.ReadLine();                 // ULAZ: Prva linija (recenica, sajt, string) => Ucitavamo prvu liniju (sajt) kao string
        while (s != null)                           // Sve do nije CTRL-Z (^Z), odnosno dok ima ulaznih podataka
        {
            if (s == "back")                        // Ako je poslednji ucitani sajt "back"
            {
                if (a.Count > 0) a.Pop();           // Iz steka se izbacuje poslednji poseceni (poslednji dodati) sajt (ako stek nije prazan)
                if (a.Count == 0)                   // Da li je stek prazan?
                    Console.WriteLine("-");         // IZLAZ: Ako je stek prazan => stampamo znak "-"
                else 
                    Console.WriteLine(a.Peek());    // IZLAZ: Ako stek nije prazan stampamo vrednost elementa na vrhu steka (koji je poslednji dodat)
            }
            else                                    // Ako poslednji ucitani sajt (string) nije "back"
            {
                a.Push(s);                          // Dodajemo vrednost poslednjeg ucitanog sajta na stek 
                Console.WriteLine(a.Peek());        // IZLAZ: Stampamo vrednost elementa na vrhu steka (koji je poslednji dodat)
            }
            s = Console.ReadLine();                 // ULAZ: Ucitavamo sledecu vrednost sajta (string) sa tasture, koji cemo obraditi u narednoj iteraciji
        }
    }
}
