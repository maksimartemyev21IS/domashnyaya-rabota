Module Module1

    Private brush As Char = "0"c

    Sub Main(args As String())

        Console.SetWindowSize(100, 50)

        Console.WriteLine("выберите задачу:
                           1 - Горизонтальная
                           2 - Вертикальная 
                           3 - Закрашенный квадрат 
                           4 - Пустой квадрат
                           5 - Клетки
                           6 - Множество клеток
                           7 - Линеечки")


        Dim N As Integer

        N = CInt(Console.ReadLine())

        Select Case N

            Case 1 : Hline(10, 10, 15)
            Case 2 : Vline(10, 10, 15)
            Case 3 : FilRect(5, 5, 10, 15)
            Case 4 : Rect(10, 10, 15, 20)
            Case 5
                Console.ForegroundColor = ConsoleColor.Blue
                Console.BackgroundColor = ConsoleColor.Red
                Console.SetCursorPosition(1, 1)
                Console.Clear()

                For i As Byte = 0 To 6
                    Hline(10, 5 * i + 8, 90)
                Next

                For i As Byte = 0 To 6
                    Vline(15 * i + 10, 8, 32)
                Next

            Case 6
                For j As Byte = 0 To 15
                    For i As Byte = 0 To 8
                        FilRect(7 * i + 10, j * 10, 4, 4)
                    Next
                Next
            Case 7
                For i As Byte = 0 To 8
                    Hline(5, 5 * i + 8, 98)
                Next
        End Select




        Console.Read()

    End Sub

    Sub Rect(leftX As Byte, topY As Byte, width As Byte, heigth As Byte)

        Hline(leftX, topY, width)

        Vline(leftX, topY, heigth)

        Hline(leftX, topY + heigth - 1, width)

        Vline(leftX + width - 1, topY, heigth)

    End Sub

    Sub Hline(leftX As Byte, topY As Byte, lent As Byte)

        Console.SetCursorPosition(leftX, topY)
        For i = 1 To lent

            Console.Write(brush)

        Next

    End Sub

    Sub Vline(leftX As Byte, topY As Byte, width As Byte)

        Console.SetCursorPosition(leftX, topY)

        For i = 0 To width - 1

            Console.Write(brush)

            Console.SetCursorPosition(leftX, topY + i)

        Next

    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, heigth As Byte)

        Console.SetCursorPosition(leftX, topY)

        For i As Byte = 1 To heigth

            Hline(leftX, topY + i, width)

        Next

    End Sub

End Module
