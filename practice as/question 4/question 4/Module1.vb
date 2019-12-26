Module Module1
    Dim input As Integer
    Dim sum As Integer
    Dim remainder, quotient As Integer
    Dim remainders(20) As Integer
    Dim i As Integer
       
    Public Function total(ByVal dividend As Integer)

        Dim sum As Integer
        Dim remainder, quotient As Integer
        Dim remainders(20) As Integer
        Dim i As Integer
        i = 0
        sum = 0
        quotient = 0
        remainder = 0
        Do
            If dividend Mod 10 >= 0 Then
                'quotient = dividend / 10
                quotient = dividend \ 10
                remainders(i) = dividend Mod 10
            End If
            dividend = quotient
            i = i + 1
        Loop Until (quotient < 11)

        For a = 0 To remainders.Length - 1
            sum = remainders(a) + sum
        Next

        sum = sum + dividend
        If sum = 10 Then
            sum = SumEqualsTen(sum)
        End If
        Return sum
    End Function
    Public Function SumEqualsTen(ByVal one As Integer)
        Dim sum As Integer
        Dim remainder, quotient As Integer
        Dim remainders(20) As Integer
        Dim i As Integer
        i = 0
        sum = 0
        quotient = 0
        remainder = 0
        Do
            If one Mod 10 >= 0 Then
                'quotient = dividend / 10
                quotient = one \ 10
                remainders(i) = one Mod 10
            End If
            one = quotient
            i = i + 1
        Loop Until (quotient < 11)

        For a = 0 To remainders.Length - 1
            sum = remainders(a) + sum
        Next

        sum = sum + one
        Return sum
    End Function
    Sub Main()
        Dim output As Integer
        Do
            input = Console.ReadLine()
        Loop Until (input > 0)
        output = total(input)
       
        If output < 10 Then
            Console.WriteLine(output)
            Console.ReadLine()
        Else

            output = total(output)

            Console.WriteLine(output)
            Console.ReadLine()
        End If

        
        ' for input 12345, 1234,123, 12,1: its correct
        'for input 123456 and more: its incorrect dont know what
    End Sub

End Module
