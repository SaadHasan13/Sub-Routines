Module Module1
    Function GetInfo() As String
        Dim ID As String = " "
        Dim PreferredName As String = " "
        Dim Valid As Boolean = False
        While Valid = False
            Console.WriteLine("Please enter a Valid User ID : ")
            ID = Console.ReadLine()
            If Len(ID) = 5 And Left(ID, 1) >= "A" And Left(ID, 1) <= "Z" And IsNumeric(Right(ID, 4)) Then
                Valid = True
            End If
        End While
        Console.WriteLine("Enter your preferred name : ")
        PreferredName = Console.ReadLine()
        Return ID & " * " & PreferredName
    End Function
    Sub Main()
        Dim SchoolRecord As String
        SchoolRecord = GetInfo()
        Console.ReadKey()
    End Sub
  
End Module
