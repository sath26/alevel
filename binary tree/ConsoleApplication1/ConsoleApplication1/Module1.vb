Module Module1
    Const NullPointer = 0
    Public Structure TreeNode
        Dim data As Integer
        Dim leftpointer As Integer
        Dim rightpointer As Integer
    End Structure
    Dim rootpointer As Integer
    Dim freeptr As Integer
    Dim tree(6) As TreeNode

    Dim newnodeptr As Integer
    Dim thisnodeptr As Integer
    Dim previousnodeptr As Integer
    Dim turnedleft As Boolean
    Sub initializetree()
        rootpointer = NullPointer
        freeptr = 1

        For index As Integer = 1 To 6
            tree(index).leftpointer = index + 1

        Next
        tree(6).leftpointer = NullPointer
    End Sub


    Sub InsertNode(ByRef NewItem)
        If freeptr <> NullPointer Then
            newnodeptr = freeptr
            freeptr = tree(freeptr).leftpointer
            tree(newnodeptr).data = NewItem
            tree(newnodeptr).leftpointer = NullPointer
            tree(newnodeptr).rightpointer = NullPointer
            If rootpointer = NullPointer Then
                rootpointer = newnodeptr
            Else
                thisnodeptr = rootpointer
                While thisnodeptr <> NullPointer
                    previousnodeptr = thisnodeptr
                    If tree(thisnodeptr).data > NewItem Then
                        turnedleft = True
                        thisnodeptr = tree(thisnodeptr).leftpointer
                    Else
                        turnedleft = False
                        thisnodeptr = tree(thisnodeptr).rightpointer
                    End If
                End While
                If turnedleft = True Then
                    tree(previousnodeptr).leftpointer = newnodeptr
                Else
                    tree(previousnodeptr).rightpointer = newnodeptr
                End If
            End If
        End If
    End Sub
    Sub OutputAllNodes()
        
        For Each item In tree
            Console.WriteLine(String.Concat("data   ", item.data, " left pointer  ", item.leftpointer, " right pointer  ", item.rightpointer))
            'Console.WriteLine($"Data {item.Data}, Pointer {item.Pointer}")
        Next
        Console.ReadLine()
    End Sub

    Sub Main()
        initializetree()
        InsertNode(2)
        InsertNode(6)
        InsertNode(8)
        InsertNode(5)
        OutputAllNodes()
        Console.ReadLine()
    End Sub

End Module
