Module Module1
    Dim repetitions As Integer
    Dim random As New Random()
    Sub Main()
        repetitions = 200
        Dim randinrange As Integer
        Dim i As Integer
        Dim num(0 To 9) As Integer
        Dim freq As Integer
        Dim difference As Integer

        freq = repetitions / 10
        For i = 0 To 9
            num(i) = 0
        Next i
        For i = 1 To repetitions
            randinrange = random.Next(1, 10)
            num(randinrange) = num(randinrange) + 1
        Next i
        Console.WriteLine("the expected frequency is" & freq)
        Console.WriteLine("number   frequency   differnce")
        For i = 1 To 9
            difference = num(i) - freq
            Console.WriteLine(i & "         " & num(i) & "             " & difference)
        Next i
        Console.ReadLine()


    End Sub

End Module
