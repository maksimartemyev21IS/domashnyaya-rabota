Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer

        Console.WriteLine("ширина")
        a = Console.ReadLine()
        Console.WriteLine("высота")
        b = Console.ReadLine()
        Console.WriteLine("координата левой стороны")
        c = Console.ReadLine()
        Console.WriteLine("координата начала верхней стороны")
        d = Console.ReadLine()

        Console.SetCursorPosition(c, d)
        For j = 0 To b - 1
            For i As Integer = 0 To a - 1
                Console.Write("1")
            Next
            Console.SetCursorPosition(c, Console.GetCursorPosition().Top + 1)
        Next

    End Sub
End Module

