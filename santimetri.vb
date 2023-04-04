Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("Я могу перевести число из см в дециметры или метры?")
        Dim input, sm, dm, m, ost As Decimal
        input = Console.ReadLine()
        m = input \ 100
        ost = input Mod 100
        dm = ost \ 10
        sm = ost Mod 10
        Console.WriteLine("{0} это {1} м, {2} дм, {3} см", input, m, dm, sm)
    End Sub
End Module
