Module Module1
    Public Sub countDownFrom(ByVal n As Integer)

        For index As Integer = n To 0 Step -1
            Console.WriteLine(index)
        Next
        Console.ReadLine()
    End Sub
    Public Sub factorialCountDownFrom(ByVal n As Integer)
        Console.WriteLine(n)

        If n > 0 Then
            factorialCountDownFrom(n - 1)
        End If

        Console.ReadLine()
    End Sub
    Sub Main()
        countDownFrom(5)
        factorialCountDownFrom(5)
    End Sub

End Module
