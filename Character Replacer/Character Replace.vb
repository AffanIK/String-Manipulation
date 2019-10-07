Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim CHR1, CHR2, nextChar As Char
        Dim Count As Integer

        STR1 = ""
        STR2 = ""
        CHR1 = ""
        CHR2 = ""
        nextChar = ""
        Count = 0

        Console.Write("Enter String : ")
        STR1 = Console.ReadLine

        Console.Write("Enter Character to replace : ")
        CHR1 = Console.ReadLine

        Console.Write("Enter Character to replace with : ")
        CHR2 = Console.ReadLine

        For Count = 1 To Len(STR1)
            nextChar = Mid(STR1, Count, 1)
            If nextChar = CHR1 Then
                STR2 = STR2 & CHR2
            Else
                STR2 = STR2 & nextChar
            End If
        Next
        Console.WriteLine("Replaced String Is : " & STR2)
        Console.ReadKey()
    End Sub

End Module
