Module Module1
    Sub binarySearch()
        Dim found As Boolean
        Dim searchFailed As Boolean
        Dim first As Integer
        Dim last As Integer

        Dim middle As Integer

        Dim list = New Integer() {11, 12, 14, 18, 20, 22, 24, 26, 30, 28}

        Dim searchItem As Integer
        searchItem = 22
        found = False
        searchFailed = False
        first = 0
        last = list.Length - 1

        While Not found And Not searchFailed
            middle = (first + last) / 2

            If list(middle) = searchItem Then
                found = True
            Else
                If first >= last Then
                    searchFailed = True
                Else

                    If list(middle) > searchItem Then
                        last = middle - 1
                    Else
                        first = middle + 1
                    End If

                End If
            End If

        End While

        If found = True Then
            Console.WriteLine(middle)
            Console.ReadLine()
        Else
            Console.WriteLine("item not present in array")
        End If
    End Sub
    Sub Main()
        binarySearch()

    End Sub

End Module

