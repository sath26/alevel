Module Module1
    Dim nullPointer As Integer = -1

    'nullpointer should be set to -1 if using array element with index 0
    Public Structure ListNode
        Public Data As Integer
        Public Pointer As Integer
    End Structure
    'declare record type to store data and pointer

    Dim counter As Integer
    Dim StartPointer As Integer = 0
    Dim FreeListPtr As Integer
    Dim List(6) As ListNode

    Sub InitialiseList()
        'StartPointer = nullPointer 'set start pointer
        FreeListPtr = 0           'set starting position of free list
        For index As Integer = 0 To 5 'link all nodes to make free list
            List(index).Pointer = index + 1
        Next

        List(6).Pointer = nullPointer 'last node of free list  
        'pointer has to be -1 as well to get result from book
    End Sub

    Dim newItem As Integer
    Dim NewNodePtr As Integer
    Dim ThisNodePtr As Integer
    Dim previousNodePtr As Integer = 0

    Sub InsertNode(ByVal newItem)

        If FreeListPtr <> nullPointer Then 'there is space in the array
            'take node from free list and store data item
            NewNodePtr = FreeListPtr '0 because first element starts from 0 of the array
            List(NewNodePtr).Data = newItem '1:8, 2:6, 3:5
            FreeListPtr = List(FreeListPtr).Pointer 'find insertion point
            'ThisNodePtr = StartPointer 'start at beginning of list
            'data is inserted then pointer needs to be updated

           


            'startpointer is 1 and  
            If FreeListPtr = 0 Then 'insert new node at start of list
                List(NewNodePtr).Pointer = -1
                StartPointer = NewNodePtr
            Else 'insert new node between previous node and this node
                List(NewNodePtr).Pointer = -1
                List(previousNodePtr).Pointer = NewNodePtr

            End If
            previousNodePtr = NewNodePtr
        End If
    End Sub
    Dim currentnodeptr As Integer

    Sub OutputAllNodes()
        StartPointer = 0
        currentnodeptr = StartPointer
        For Each item In List
            Console.WriteLine(String.Concat("data", item.Data, " pointer", item.Pointer))
            'Console.WriteLine($"Data {item.Data}, Pointer {item.Pointer}")
        Next
        Console.ReadLine()
    End Sub

    Sub Main()
        InitialiseList()
        InsertNode(8)
        InsertNode(3)
        InsertNode(5)
        OutputAllNodes()
    End Sub

End Module
