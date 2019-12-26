Module Module1
    Class LibraryItem
        Private Title As String
        Private Author_Artist As String
        Private ItemID As Integer
        Private OnLoan As Boolean = False
        Private DueDate As Date = Today

        Sub Create(ByVal t As String, ByVal a As String, ByVal i As Integer)
            Title = t
            Author_Artist = a
            ItemID = i
        End Sub

        Public Function GetTitle() As String
            Return (Title)
        End Function


        Public Sub Borrowing()
            OnLoan = True
            DueDate = DateAdd(DateInterval.Day, 21, Today()) ' 3 weeks from today
        End Sub

        Public Sub Returning()
            OnLoan = False
        End Sub

        Public Overridable Sub PrintDetails()
            Console.WriteLine(Title & ";" & ItemID & " ;" & OnLoan & ";" & DueDate)
        End Sub
    End Class

    Class Book
        Inherits Libraryitem
        Private IsRequested As Boolean = False

        Public Function GetIsRequested() As Boolean
            Return (IsRequested)
        End Function
        Public Sub SetisRequested()
            IsRequested = True
        End Sub
        Public Overrides Sub PrintDetails()
            Console.WriteLine("book details")
            MyBase.PrintDetails()
            Console.WriteLine(IsRequested)
        End Sub
    End Class

    Class CD
        Inherits Libraryitem
        Private Genre As String


        Public Function GetGenre() As String
            Return (Genre)
        End Function

        Public Sub SetGenre(ByVal g As String)
            Genre = g
        End Sub
    End Class


    Sub Main()

        Dim ThisBook As New Book()
        Dim ThisCD As New CD()
        'ThisBook.Create(Title, Author, ItemID)
        'ThisCD.Create(Title, Artist, ItemID)
        ThisBook.Create("never split the difference", "chris voss", 2)
        ThisCD.Create("one more light", "Linkin Park", 3)
        ThisBook.PrintDetails()
        ThisCD.PrintDetails()
        Console.ReadLine()
    End Sub

End Module
