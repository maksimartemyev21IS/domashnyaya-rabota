Imports System

Module Program
    Sub Main(args As String())
        Dim w As Integer
        Dim h, he As Integer
        Dim l, le As Integer
        Dim t, top As Integer

        Console.WriteLine("ширину")
        w = Console.ReadLine()
        Console.WriteLine("высоту")
        h = Console.ReadLine()
        Console.WriteLine("координата левой стороны")
        l = Console.ReadLine()
        Console.WriteLine("координата начала верхней стороны")
        t = Console.ReadLine()

        Console.SetCursorPosition(l, t)
        For j = 0 To h - 1
            For i As Integer = 0 To w - 1
                Console.Write("1")
            Next
            Console.SetCursorPosition(l, Console.GetCursorPosition().Top + 1)
        Next

    End Sub
End Module
