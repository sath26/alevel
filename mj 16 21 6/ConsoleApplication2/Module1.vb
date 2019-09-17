Module Module1

    Sub Main()
        Dim n, f, x, y As Integer
        Dim string1, string2 As String
        n = 0
        f = 0
        string1 = "retrace"
        string2 = "rac"
        Do
            n = n + 1
            x = n
            y = 1

            Do While Mid(string1, x, 1) = Mid(string2, y, 1)

                If y = Len(string2) Then
                    f = n
                Else
                    x = x + 1
                    y = y + 1
                End If
                Console.WriteLine(n & f & x & y & Mid(string1, x, 1) & Mid(string2, y, 1))
            Loop

        Loop Until n = Len(string1) Or f <> 0
        Console.ReadLine()
    End Sub

End Module
