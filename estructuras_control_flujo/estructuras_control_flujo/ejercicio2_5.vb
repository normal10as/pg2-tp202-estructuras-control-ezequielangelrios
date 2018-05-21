Module ejercicio2_5
    Sub Main()
        Dim meses As Integer
        Console.WriteLine("Selecciones el mes que desea ver: ")
        meses = Console.ReadLine()

        If (meses > 12 Or meses < 1) Then
            Console.WriteLine("No existe el mes!")
        End If

        Select Case meses
            Case 1
                Console.WriteLine("Enero")
            Case 2
                Console.WriteLine("Febrero")
            Case 3
                Console.WriteLine("Marzo")
            Case 4
                Console.WriteLine("Abril")
            Case 5
                Console.WriteLine("Mayo")
            Case 6
                Console.WriteLine("Junio")
            Case 7
                Console.WriteLine("Julio")
            Case 8
                Console.WriteLine("Agosto")
            Case 9
                Console.WriteLine("Septiembre")
            Case 10
                Console.WriteLine("Octubre")
            Case 11
                Console.WriteLine("Noviembre")
            Case 12
                Console.WriteLine("Diciembre")
        End Select

        Console.ReadLine()

    End Sub

End Module
