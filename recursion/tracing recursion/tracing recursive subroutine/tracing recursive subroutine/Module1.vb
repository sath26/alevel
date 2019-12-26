Module Module1
   
    Public Sub factorialCountDownFrom(ByVal n As Integer)


        If n > 0 Then
            factorialCountDownFrom(n - 1)
        End If
        Console.WriteLine(n)
        Console.ReadLine()
    End Sub
    Sub Main()

        factorialCountDownFrom(5)
    End Sub

End Module

