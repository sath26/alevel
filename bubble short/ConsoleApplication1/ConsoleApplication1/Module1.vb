Module Module1
    Sub Main()
        Dim temp As String
        Dim firstid, secondId As Integer
        Dim noswaps As Boolean
        Dim boundary As Integer
        Dim j As Integer = 0
        boundary = 8
        Dim userNameArray() As Integer = {1, 2, 4, 6, 5, 3, 9, 7, 8}
        Do
            noswaps = True
            For j = 1 To boundary
                firstid = userNameArray(j - 1)
                'If userNameArray(j + 1) < boundary Then
                secondId = userNameArray(j)
                'End If
                If firstid > secondId Then
                    temp = userNameArray(j - 1)
                    userNameArray(j - 1) = userNameArray(j)
                    userNameArray(j) = temp
                    noswaps = False
                End If
            Next
            boundary = boundary - 1
        Loop Until noswaps = True
    End Sub
End Module
