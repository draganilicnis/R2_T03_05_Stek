// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/linije_u_obratnom_redosledu
using System;
using System.Collections.Generic;
class R2_T03_05_Stek
{
    static void Main()
    {
        var a = new Stack<string>();
        string s = Console.ReadLine();
        while (s != null)
        {
            a.Push(s);
            s = Console.ReadLine();
        }
        while (a.Count > 0)
            Console.WriteLine(a.Pop());
    }
}
