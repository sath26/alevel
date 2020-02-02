Module Module1

    Public Class ListNode
        Public Data As Integer
        Public Pointer As Integer
        Public Sub New(ByVal p As Integer)
            Pointer = p
        End Sub
    End Class

    Private InputList As New List(Of Integer)
    Private MySortedLinkedList As New List(Of ListNode)

    Sub Main()
        InitialiseList()
        InputList.Add(10)
        InputList.Add(8)
        InputList.Add(6)
        InputList.Add(4)
        InputList.Add(5)
        'InputList.Add(9)
        AddDataToList(InputList)
        OutputAllNodes()
        Console.ReadLine()
    End Sub

    Private Sub AddDataToList(ByVal lst As List(Of Integer))
        lst.Sort()
        Dim index As Integer
        For Each item In lst
            MySortedLinkedList(index).Data = item
            index += 1
        Next
    End Sub

    Sub InitialiseList()
        For index As Integer = 0 To 5 'link all nodes to make free list
            MySortedLinkedList.Add(New ListNode(index + 1))
        Next
        MySortedLinkedList.Add(New ListNode(-1)) 'last node of free list    
    End Sub

    Sub OutputAllNodes()
        For Each item In MySortedLinkedList
            Console.WriteLine(String.Concat("data", item.Data, " pointer", item.Pointer))
            'or in pre Visual Studio 2015
            'Console.WriteLine(String.Format("Data {0}, Pointer {1}", item.Data, item.Pointer)
        Next
        Console.ReadLine()
    End Sub

End Module