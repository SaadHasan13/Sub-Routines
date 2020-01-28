Module Module1
    Function ProcessMarks(ByVal Mark() As Integer) As Integer
        Dim Highest, I, Total, Average, Position As Integer
        Total = 0
        Position = 1
        Highest = Mark(1)
        For I = 1 To 20
            Total = Total + Mark(I)
            If Mark(I) > Highest Then
                Highest = Mark(I)
                Position = I
            End If
        Next
        Average = Total / 20
        Console.WriteLine("The average mark is " & Average & " The highest mark is " & Highest)
        Return Position
    End Function
    Sub Main()
        Console.ReadKey()

    End Sub

End Module
