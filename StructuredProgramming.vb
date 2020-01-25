Module Module1

    Sub Main()
        Dim choice As Integer = 0
        Do
            Call OptionsDisplay()
            Console.WriteLine("Enter choice (0 ... 3) :")
            choice = Console.ReadLine()

            Select Case choice
                Case  = 0
                Case Is = 1 : Call Choice1()
                Case Is = 2 : Call Choice2()
                Case Is = 3 : Call Choice3()
                Case Else : Console.WriteLine("Invalid choice. Enter between 0...3")
            End Select
            Console.ReadKey()
        Loop Until choice = 0
    End Sub
    Sub OptionsDisplay()
        Console.Clear()
        Console.WriteLine(" 1. Option 1.")
        Console.WriteLine(" 2. Option 2.")
        Console.WriteLine(" 3. Option 3.")
        Console.WriteLine(" 0. Quit Program.")
    End Sub
    Sub Choice1()
        Console.WriteLine("Sub choice 1 was called ...")
    End Sub
    Sub Choice2()
        Console.WriteLine("Sub choice 2 was called ...")
    End Sub
    Sub Choice3()
        Console.WriteLine("Sub choice 3 was called ...")
    End Sub
End Module
