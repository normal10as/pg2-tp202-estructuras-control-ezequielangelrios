Module ejercicio2_9
    Sub Main()
        Dim menu As Int16
        Dim valor As Int16
        Dim converpies, converpulgadas, converyardas, convercentimetros, convermetros As Double
        Console.WriteLine("Seleccione que medida desea convertir: ")
        Console.WriteLine("1=Metros, 2=Centimetros, 3=Yardas, 4=Pies, 5=Pulgadas")
        menu = Console.ReadLine()
        If (menu < 1 Or menu > 5) Then
            Console.WriteLine("Error")
        End If

        Console.WriteLine("Ingrese en valor a convertir: ")
        valor = Console.ReadLine()
        If (menu = 1) Then
            converpies = valor * 3.28
            convercentimetros = valor * 100
            converpulgadas = valor * 39.37
            converyardas = valor * 1.09
            Console.WriteLine("Usted ha seleccionado {0} metros", valor)
            Console.WriteLine("Son pies {0}, {1}cm, {2}yardas, {3}pulgadas ",
                              converpies, convercentimetros, converyardas, converpulgadas)
        End If
        If (menu = 2) Then
            converpies = valor * 0.03
            converyardas = valor * 0.01
            converpulgadas = valor * 0.39
            convermetros = valor * 0.01
            Console.WriteLine("Usted ha seleccionado {0} centimetros", valor)
            Console.WriteLine("Son pies {0}, {1}metros, {2}yardas, {3}pulgadas ",
                              converpies, convermetros, converyardas, converpulgadas)
        End If
        If (menu = 3) Then
            converpies = valor * 3
            converpulgadas = valor * 36
            convermetros = valor * 0.91
            convercentimetros = valor * 91.44
            Console.WriteLine("Usted ha seleccionado {0} Yardas", valor)
            Console.WriteLine("Son pies {0}, {1}metros, {2}pulgadas, {3}centimetros ",
                              converpies, convermetros, converpulgadas, convercentimetros)
        End If
        If (menu = 4) Then
            converpulgadas = valor * 12
            converyardas = valor * 0.33
            convermetros = valor * 0.3
            convercentimetros = valor * 30.48
            Console.WriteLine("Usted ha seleccionado {0} Pies", valor)
            Console.WriteLine("Son yardas {0}, {1}metros, {2}pulgadas, {3}centimetros ",
                                converyardas, convermetros, converpulgadas, convercentimetros)
        End If
        If (menu = 5) Then
            converyardas = valor * 0.02
            convermetros = valor * 0.02
            convercentimetros = valor * 2.54
            converpies = valor * 0.08
            Console.WriteLine("Usted ha seleccionado {0} Pulgadas", valor)
            Console.WriteLine("Son yardas {0}, {1}metros, {2}centimetros, {3}pies",
                                converyardas, convermetros, convercentimetros, converpies)
        End If
        Console.ReadLine()
    End Sub

End Module
