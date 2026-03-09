// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/linije_u_obratnom_redosledu
using System;
using System.Collections.Generic;
class R2_T03_05_Stek_Linije_u_obratnom_redosledu
{
    static void Main()
    {
        // Zadatak_Od_N_do_1();
        Zadatak_Linije_u_obratnom_redosledu();
    }

    static void Zadatak_Od_N_do_1()
    {
        int n = int.Parse(Console.ReadLine());
        Ver_00_Od_N_do_1_For(n);
        Ver_01_Niz(n);
        Ver_02_Lista(n);
        Ver_03_Stek_Foreach(n);
        //Ver_04_Stek_Peek(n);
        Ver_05_Stek_Pop(n);
    }

    static void Ver_00_Od_N_do_1_For(int n)
    {
        for (int i = n; i >= 1; i--) Console.WriteLine(i);
    }

    static void Ver_01_Niz(int n)
    {
        var a = new int[n + 1];
        for (int i = 0; i <= n; i++) a[i] = i;
        for (int i = n; i >= 1; i--) Console.WriteLine(a[i]);
    }
    static void Ver_02_Lista(int n)
    {
        var a = new List<int>();
        for (int i = 0; i <= n; i++) a.Add(i);
        for (int i = n; i >= 1; i--) Console.WriteLine(a[i]);
    }
    static void Ver_03_Stek_Foreach(int n)
    {
        var a = new Stack<int>();
        for (int i = 1; i <= n; i++) a.Push(i);
        foreach (int i in a) Console.WriteLine(i);
    }
    static void Ver_04_Stek_Peek(int n)
    {
        var a = new Stack<int>();
        for (int i = 1; i <= n; i++) a.Push(i);
        for (int i = 1; i <= n; i++) Console.WriteLine(a.Peek());
    }
    static void Ver_05_Stek_Pop(int n)
    {
        var a = new Stack<int>();
        for (int i = 1; i <= n; i++) a.Push(i);
        while (a.Count > 0) Console.WriteLine(a.Pop());
    }
    static void Zadatak_Linije_u_obratnom_redosledu()
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
