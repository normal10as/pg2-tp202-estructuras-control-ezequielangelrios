Module ejercicio2_8
    Sub Main()
        Dim mes As Integer
        Dim num As Integer
        Dim bisiesto As Integer
        Console.WriteLine("ingrese el numero de mes:")
        mes = Console.ReadLine
        Console.WriteLine("ingrese el año: ")
        num = Console.ReadLine
        If (num Mod 4 = 0 And num Mod 100 <> 0 Or num Mod 400 = 0) Then
            bisiesto = 1
            Console.WriteLine("el anio es bisiesto")
        Else
            Console.WriteLine("el anio no es bisiesto")
        End If
        Select Case mes
            Case 1
                Console.WriteLine("Mes Enero, dias: 31")
            Case 2
                If (bisiesto = 1) Then
                    Console.WriteLine("Mes Febrero, dias: 29")
                Else
                    Console.WriteLine("Mes febrero, dias: 28")
                End If
            Case 3
                Console.WriteLine("Mes Marzo, dias: 31")
            Case 4
                Console.WriteLine("Mes Abril, dias: 30")
            Case 5
                Console.WriteLine("Mes Mayo, dias: 31")
            Case 6
                Console.WriteLine("Mes Junio, dias: 30")
            Case 7
                Console.WriteLine("Mes Julio, dias: 31")
            Case 8
                Console.WriteLine("Mes Agosto, dias: 31")
            Case 9
                Console.WriteLine("Mes Septiembre, dias: 30")
            Case 10
                Console.WriteLine("Mes Octubre, dias: 31")
            Case 11
                Console.WriteLine("Mes Noviembre, dias: 30")
            Case 12
                Console.WriteLine("Mes Diciembre, dias: 31")
        End Select
        Console.ReadLine()
    End Sub

End Module
