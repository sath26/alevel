Module Module1
    Dim a As Integer

    Sub Main()
        a = 0
        For index As Integer = 1 To 10
            a = index + a
        Next
        Console.WriteLine(a)
        Console.ReadLine()
    End Sub

End Module
