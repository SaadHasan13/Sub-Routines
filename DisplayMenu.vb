Module Module1

    Sub Main()
        Dim Choice, NoOfAttempts As Integer
        Const I = 3
        Do
            Call DisplayMenu()
            NoOfAttempts = 0
            Do
                Console.Write("Enter choice (1...4) :")
                Choice = Console.ReadLine
                NoOfAttempts = NoOfAttempts + 1
            Loop Until (Choice >= 1 And Choice <= 4) Or NoOfAttempts = I

            If Choice = 1 Then Call ReadFile()
            If Choice = 2 Then Console.WriteLine("Add Customer Code")
            If Choice = 3 Then Console.WriteLine("Search Customer Code")
        Loop Until Choice = 4
    End Sub
    Sub DisplayMenu()
        Console.WriteLine()
        Console.WriteLine("1. Read Customer File")
        Console.WriteLine("2. Add Customer")
        Console.WriteLine("3. Search Customer")
        Console.WriteLine("4. End")
        Console.WriteLine()
    End Sub

    Sub ReadFile()
        Console.WriteLine("Read file code")
        Console.ReadKey()
    End Sub
End Module
