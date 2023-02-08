Imports System

Module program
    Private brush As Char = "0"c
    Sub Main(args As String())

        Console.SetWindowSize(100, 50)
        For i = 1 To 7
            Hline(2, 2 + i * 6, 100)
        Next

        Console.WriteLine()
    End Sub
    Sub Hline(LeftX As Byte, TopY As Byte, Lenght As Byte)
        Console.SetCursorPosition(LeftX, TopY)
        For i = 1 To Lenght
            Console.Write(brush)

        Next
    End Sub
End Module

