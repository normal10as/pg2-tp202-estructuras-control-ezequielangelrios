Module ejercicio2_7
    Sub Main()

        Dim angulo As Integer
        Console.WriteLine("Ingrese el tamaño del angulo: ")
        angulo = Console.ReadLine()
        Select Case angulo
            Case 0 To 90
                Console.WriteLine("El angulo ingresado es AGUDO")
            Case 90
                Console.WriteLine("El angulo ingresado es RECTO")
            Case 90 To 179
                Console.WriteLine("El angulo ingresado es OBTUSO")
            Case 180
                Console.WriteLine("El angulo ingresado es LLANO")
            Case 180 To 359
                Console.WriteLine("El angulo ingresado es CÓNCAVO")
            Case < 0
                Console.WriteLine("Error")
            Case > 360
                Console.WriteLine("Error")
        End Select
        Console.ReadLine()
    End Sub

End Module
