Module Module1
    Dim Alpha(26) As Integer
    Sub Main()

        Dim count As Integer

        For count = 1 To 26
            Alpha(count) = 0
        Next

        Call ReadFile()
        Call OutputArray()
        Console.ReadKey()
    End Sub

    Sub ReadFile()
        Dim FileRecord As String = ""
        FileOpen(1, "e:\vbprac\Strings.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, FileRecord)
            Call UpdateArray(FileRecord)
        End While

        FileClose(1)
    End Sub

    Sub UpdateArray(ByVal FileRecord As String)
        Dim count As Integer = 0
        Dim character As Char = ""

        For count = 1 To Len(FileRecord)
            character = Mid(FileRecord, count, 1)
            Alpha(Asc(UCase(character)) - 64) = Alpha(Asc(UCase(character)) - 64) + 1
        Next
    End Sub

    Sub OutputArray()
        Dim count As Integer = 0
        Dim letter As Char = ""
        For count = 65 To 90
            letter = Chr(count)
            Console.WriteLine(letter & " = " & Alpha(count - 64))
        Next
    End Sub

End Module
