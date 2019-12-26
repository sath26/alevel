Module Module1

    Public Structure ListNode
        Public Data As Integer
        Public Pointer As Integer
    End Structure

    Private CurrentIndex As Integer
    Private NodeList(6) As ListNode 'Seven elements in the array

    Sub Main()
        InitialiseList()
        InsertNode(6)
        InsertNode(4)
        InsertNode(3)
        OutputAllNodes()
    End Sub

    Private Sub InsertNode(ByVal input As Integer)
        NodeList(CurrentIndex).Data = input
        CurrentIndex += 1
    End Sub

    Sub InitialiseList()
        For index As Integer = 0 To 5 'link all nodes to make free list
            NodeList(index).Pointer = index + 1
        Next
        NodeList(6).Pointer = -1 'last node of free list  
    End Sub

    Sub OutputAllNodes()
        
        For Each item In NodeList
            Console.WriteLine(String.Concat("data", item.Data, " pointer", item.Pointer))
            'Console.WriteLine($"Data {item.Data}, Pointer {item.Pointer}")
        Next
        Console.ReadLine()
    End Sub

End Module
