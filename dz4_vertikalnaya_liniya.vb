Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b, le As Integer
        Dim c, top As Integer

        Console.WriteLine("������ �����")
        a = Console.ReadLine()
        Console.WriteLine("���������� �����")
        le = Console.ReadLine()
        Console.WriteLine("���������� ����")
        top = Console.ReadLine()

        Console.SetCursorPosition(b, c)
        For j = 0 To a - 1
            For i As Integer = 0 To 1
                Console.Write("E")
            Next
            Console.SetCursorPosition(l, Console.GetCursorPosition().Left + 1)
        Next
    End Sub
End Module