Module Module1
    Dim TaskGrid(5, 12) As Boolean

    Sub Main()
        Dim StaffNum As Integer
        Dim TaskNum As Integer
        Dim Completed As Integer

        Dim NewStaffTask As Boolean
        Call InitialiseTaskGrid()
        Completed = 0
        While Completed <> 60
            NewStaffTask = False
            While NewStaffTask = False
                StaffNum = Int((Rnd() * 5 + 1))
                TaskNum = Int((Rnd() * 12 + 1))
                If TaskGrid(StaffNum, TaskNum) = False Then
                    TaskGrid(StaffNum, TaskNum) = True
                    NewStaffTask = True
                    Console.WriteLine(StaffNum, TaskNum)
                End If
            End While
            Completed = Completed + 1
        End While
        Console.WriteLine("Staff Task Count: " & Completed)
        Console.ReadKey()
    End Sub
    Sub InitialiseTaskGrid()
        Dim I As Integer
        Dim J As Integer
        For I = 1 To 5
            For J = 1 To 12
                TaskGrid(I, J) = False
            Next
        Next
    End Sub
End Module
