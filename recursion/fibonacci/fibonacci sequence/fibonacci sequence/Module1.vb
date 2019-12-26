Module Module1
    'each number in the sequence is the addition or sum of the two previous numbers.
    Function Fibonacci(ByVal n As Integer) As Integer

        If n = 0 Then
            Return 0
        End If
        If n = 1 Then
            Return 1
        End If
        Dim first As Integer = 0
        Dim second As Integer = 1
        Dim nth As Integer = 1

        For index As Integer = 2 To n
            nth = first + second
            first = second
            second = nth
        Next

        Return nth
    End Function

    Sub outputFibonacci(ByVal number)
        For i As Integer = 0 To number
            Console.WriteLine(Fibonacci(i))
        Next

    End Sub
    Sub outputFibonacciRecursive(ByVal number)
        'For i As Integer = 0 To number
        '   Console.WriteLine(FibonacciRecursive(i))
        'Next
        Console.WriteLine(FibonacciRecursive(number))
    End Sub
    Function FibonacciRecursive(ByVal number As Integer) As Long


        If number = 1 OrElse number = 0 Then
            Return number
        Else
            Return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2)
        End If

    End Function
    Sub Main()
        ' Display first 10 Fibonacci numbers.
        'Output : 0 1 1 2 3 5 8 13 21 34 55
        'outputFibonacci(10)
        'Console.ReadLine()
        outputFibonacciRecursive(10)
        Console.ReadLine()
    End Sub

End Module

