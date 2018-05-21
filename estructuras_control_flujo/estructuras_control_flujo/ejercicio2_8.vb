Module ejercicio2_8
    Sub Main()
        Dim mes As Integer
        Dim num As Integer
        Console.WriteLine("ingrese el numero de mes:")
        mes = Console.ReadLine
        Console.WriteLine("ingrese el año: ")
        num = Console.ReadLine
        If (num Mod 4 = 0 And num Mod 100 <> 0 Or num Mod 400 = 0) Then
            Console.WriteLine("el anio es bisiesto")
        Else
            Console.WriteLine("el anio no es bisiesto")

        End If
        Select Case mes
            Case 1
                Console.WriteLine("Enero")
        End Select
        Console.ReadLine()
    End Sub

End Module
