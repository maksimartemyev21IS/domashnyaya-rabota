﻿Imports System

Module program
    Private brush As Char = "0"c
    Sub Main(args As String())

        Console.SetWindowSize(100, 50)

        Hline(2, 2, 20)
        Vline(2, 2, 10)
        Hline(2, 10, 20)
        Vline(21, 2, 10)


        Console.WriteLine()
    End Sub

    'построение горизонтальных линий
    Sub Hline(LeftX As Byte, TopY As Byte, Lenght As Byte)
        Console.SetCursorPosition(LeftX, TopY)
        For i = 1 To Lenght
            Console.Write(brush)

        Next
    End Sub

    'построение вертикальных линий
    Sub Vline(leftX As Byte, TopY As Byte, widht As Byte)
        Console.SetCursorPosition(leftX, TopY)
        For i = 0 To widht - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, TopY + i)

        Next
    End Sub
End Module

