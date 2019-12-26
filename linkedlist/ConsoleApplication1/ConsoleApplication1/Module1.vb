Module Module1
    Dim nullPointer As Integer

    'nullpointer should be set to -1 if using array element with index 0
    Public Structure ListNode
        Public Data As Integer
        Public Pointer As Integer
    End Structure
    'declare record type to store data and pointer
    Dim counter As Integer

    Dim StartPointer As Integer
    Dim FreeListPtr As Integer
    Dim List(6) As ListNode

    Sub InitialiseList()
        nullPointer = -1

        StartPointer = nullPointer 'set start pointer
        FreeListPtr = 0            'set starting position of free list


        For index As Integer = 0 To 5 'link all nodes to make free list


            List(index).Pointer = index + 1


        Next
        List(6).Pointer = nullPointer 'last node of free list
    End Sub
    Dim newItem As Integer
    Dim NewNodePtr As Integer
    Dim ThisNodePtr As Integer
    Dim previousNodePtr As Integer

    Sub InsertNode(ByVal newItem)
        nullPointer = -1
        StartPointer = 0
        FreeListPtr = 0
        If FreeListPtr <> nullPointer Then 'there is space in the array
            'take node from free list and store data item
            NewNodePtr = FreeListPtr
            List(NewNodePtr).Data = newItem
            FreeListPtr = List(FreeListPtr).Pointer 'find insertion point
            ThisNodePtr = StartPointer 'start at beginning of list

            While ThisNodePtr <> nullPointer And List(ThisNodePtr).Data < newItem
                'while not end ofl list

                previousNodePtr = ThisNodePtr 'remember this node follow the pointer to the next node
                ThisNodePtr = List(ThisNodePtr).Pointer

            End While


            If previousNodePtr = StartPointer Then 'insert new node at start of list
                List(NewNodePtr).Pointer = StartPointer
                StartPointer = NewNodePtr
            Else 'insert new node between previous node and this node
                List(NewNodePtr).Pointer = List(previousNodePtr).Pointer
                List(previousNodePtr).Pointer = NewNodePtr
            End If

        End If
    End Sub
    Dim currentnodeptr As Integer

    Sub OutputAllNodes()
        nullPointer = -1
        StartPointer = 0
        currentnodeptr = StartPointer


        While currentnodeptr <> nullPointer
            Console.WriteLine(List(currentnodeptr).Data)
            currentnodeptr = List(currentnodeptr).Pointer
        End While
        Console.ReadLine()
    End Sub

    Sub Main()
        InitialiseList()
        InsertNode(2)
        InsertNode(3)
        InsertNode(4)
        OutputAllNodes()
    End Sub

End Module
