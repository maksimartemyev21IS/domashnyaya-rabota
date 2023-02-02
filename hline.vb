Imports System

Module linii
    Private brush As Char = "0c"
    Sub Main(args As String())

        Console.SetWindowSize(100, 50)

        filRect(10, 5, 10, 35)

        Console.WriteLine()

    End Sub

    Sub Hline(LeftX As Byte, topY As Byte, lenght As Byte)
        Console.SetCursorPosition(LeftX, topY)
        For i = 1 To lenght
            Console.Write(brush)
        Next
    End Sub

    Sub vline(LeftX As Byte, topY As Byte, lenght As Byte)
        Console.SetCursorPosition(LeftX, topY)
        For i = 0 To lenght - 1
            Console.Write(brush)
            Console.SetCursorPosition(LeftX, topY + i)
        Next
    End Sub

    Sub filRect(LeftX As Byte, topY As Byte, widht As Byte, height As Byte)
        Console.SetCursorPosition(LeftX, topY)
        For j = 0 To height - 1
            Hline(LeftX, topY + j, widht)
        Next
    End Sub
End Module


