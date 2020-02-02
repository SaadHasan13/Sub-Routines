Module Module1
    Function ValidatePassword(InString As String) As Boolean
        Dim Lchar, Uchar, NumChar, Count As Integer
        Dim NextChar As Char
        Dim Flag As Boolean

        Lchar = 0
        Uchar = 0
        NumChar = 0
        Flag = True
        For Count = 1 To Len(InString)
            NextChar = Mid(InString, Count, 1)
            If NextChar > "a" And NextChar < "z" Then
                Lchar = Lchar + 1
            Else
                If NextChar > "A" And NextChar < "Z" Then
                    Uchar = Uchar + 1
                Else
                    If NextChar > "0" And NextChar < "9" Then
                        NumChar = NumChar + 1
                    Else
                        Flag = False
                    End If
                End If
            End If
        Next
        If Not (Lchar >= "2" And Uchar >= "2" And NumChar >= "3") Then
            Flag = False
        End If
        Return Flag
    End Function
    Sub Main()
        Dim Pass As String
        Console.Write("Input your password for check: ")
        Pass = Console.ReadLine()
        Console.WriteLine("The password you entered is : " & ValidatePassword(Pass))
        Console.ReadKey()
    End Sub

End Module
