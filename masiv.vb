Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Enter 5 numbers:")
        Dim input(4) As Integer

        For i = 0 To 4
            input(i) = Console.ReadLine()
        Next

        Console.WriteLine("what number to find?")
        Dim num As Integer = Console.ReadLine()

        Console.WriteLine(find(input, num))

    End Sub
    Sub Print(List As Integer())
        For i = 0 To List.Length - 1
            Console.WriteLine(List(i))
        Next
    End Sub
    Sub Print(List As String())
        For i = 0 To List.Length - 1
            Console.WriteLine(List(i))
        Next
    End Sub
    Sub printreverse(List As Integer())
        For i = List.Length - 1 To 0 Step -1
            Console.WriteLine(List(i))
        Next
    End Sub
    Sub printreverse(List As String())
        For i = List.Length - 1 To 0 Step -1
            Console.WriteLine(List(i))
        Next
    End Sub
    Function find(List As Integer(), num As Integer) As String
        For i = 0 To List.Length - 1
            If List(i) = num Then
                find = i
                Exit Function
            End If
            find = -1
        Next
    End Function
End Module

