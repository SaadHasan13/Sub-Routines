Module Module1
    Function IsFactor(ByVal Num1 As Integer, ByVal Num2 As Integer) As Boolean
        If Num2 <> 0 Then
            If Num1 Mod Num2 Then
                Return True
            End If
        End If
        Return False
    End Function
    Sub Main()
        Dim Remainder As Integer
        Dim K As Integer
        Dim M As Integer
        K = Console.ReadLine
        M = Console.ReadLine
        Remainder = IsFactor(K, M)

        Console.ReadKey()
    End Sub

End Module
