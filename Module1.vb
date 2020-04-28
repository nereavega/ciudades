Module Module1
    Private Function ordenarLetras(ciudad As String) As String
        Dim resultado As String = ""
        Dim a As Char()
        ciudad = ciudad.ToLower
        For i As Integer = 0 To ciudad.Length
            a(i) = GetChar(ciudad, i)
        Next i
        Array.Sort(a)
        For i As Integer = 0 To ciudad.Length
            resultado = resultado + (a(i))
        Next i
        Return resultado
    End Function
    Sub Main(args As String())
        Dim resultado As String = ""
        Dim ciudad As String() = {"Tokyo", "London", "Rome", "Donlon", "Kyoto", "Paris"}
        Dim ciudadOrdenada As String()

        For i As Integer = 0 To i < ciudad.Length
            ciudadOrdenada(i) = ordenarLetras(ciudad(i))
        Next i
        For i As Integer = 0 To i < ciudadOrdenada.Length
            For j As Integer = 0 To j < ciudadOrdenada.Length
                If (ciudadOrdenada(i).Equals(ciudadOrdenada(j))) Then
                    resultado = resultado + "| " + ciudad(j)
                    ciudad(j) = vbEmpty
                End If
            Next j
            resultado += vbCrLf
        Next i
        Console.WriteLine(resultado)

    End Sub

End Module
