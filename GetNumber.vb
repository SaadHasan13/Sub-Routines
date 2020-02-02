Module Module1
    Function GetNumber() As String
        Dim Valid As Boolean
        Dim MemberShipNo As Integer
        Do
            Valid = True
            Console.Write("Please enter a valid number :")
            MemberShipNo = Console.ReadLine()
            If MemberShipNo > 1111 And MemberShipNo < 9999 Then
                Valid = False
            End If
        Loop Until Valid = True
        Return MemberShipNo.ToString()
    End Function
    Sub Main()
        Dim MemberShipNumber As Integer
        MemberShipNumber = GetNumber()
        Console.ReadKey()
    End Sub

End Module
