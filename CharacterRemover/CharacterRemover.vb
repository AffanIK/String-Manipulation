Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim myChar, nextChar As Char
        Dim Counter As Integer

        str1 = ""
        str2 = ""
        myChar = ""
        nextChar = ""
        Counter = 0

        Console.Write("Enter String : ")
        str1 = Console.ReadLine

        Console.Write("Enter character to remove : ")
        myChar = Console.ReadLine

        For Counter = 1 To Len(str1)
            nextChar = Mid(str1, Counter, 1)
            If nextChar <> myChar Then
                str2 = str2 & nextChar
            End If
        Next
        Console.WriteLine("Final String = " & str2)
        Console.ReadKey()
    End Sub

End Module
