Module Module1

    Sub Main()
        For x = 0 To 41
            For y = 0 To 41
                For z = 0 To 41
                    For i = 0 To 41
                        If x + y + z + i = 41 Then
                            If (x ^ 2) + (y ^ 2) + (z ^ 2) + (i ^ 2) = 579 Then
                                If (x ^ 3) + (y ^ 3) + (z ^ 3) + (i ^ 3) = 10241 Then
                                    If (x ^ 4) + (y ^ 4) + (z ^ 4) + (i ^ 4) = 201603 Then
                                        Console.WriteLine(x & " " & y & " " & z & " " & i)
                                    End If
                                End If
                            End If
                        End If
                    Next
                Next
            Next
        Next
        Console.ReadKey()
    End Sub

End Module
