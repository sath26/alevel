Module Module1
    Dim symbol As String
    Dim MaxNumberOfSymbols, NumberOfSpaces, NumberOfSymbols As Integer
    Sub Main()
        symbol = Console.ReadLine()
        ' Input max number of symbols (an odd number)
        Do
            MaxNumberOfSymbols = Console.ReadLine()
        Loop Until (MaxNumberOfSymbols Mod 2 = 1)


        NumberOfSpaces = (MaxNumberOfSymbols - 1) / 2
        NumberOfSymbols = 1
        Do
            'Output number of spaces

            For index As Integer = 1 To NumberOfSpaces
                Console.Write(" ") ' without moving to next line
            Next


            'Output number of symbols
            For i As Integer = 1 To NumberOfSymbols
                Console.Write(symbol) 'without moving to next line
            Next
            Console.WriteLine() 'move to the next line
            'Adjust Values For Next Row
            NumberOfSpaces = NumberOfSpaces - 1
            NumberOfSymbols = NumberOfSymbols + 2
        Loop Until (NumberOfSymbols > MaxNumberOfSymbols)
        Console.ReadLine
    End Sub

End Module
