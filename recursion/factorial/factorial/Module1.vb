Module Module1
    Public Function factorialLoop(ByVal n As Integer)
        Dim result As Integer
        result = 1
        For index As Integer = 1 To n
            result = result * index
        Next
        Return result
    End Function


    Public Function factorial(ByVal n As Integer)
        'Dim result As Integer

        If n = 0 Then
            Return 1
        Else
            Return n * factorial(n - 1)
        End If

        'Return result
    End Function
    Sub Main()
        Console.WriteLine(factorial(5))

        'Console.WriteLine(factorialLoop(5))
        Console.ReadLine()

    End Sub

End Module
