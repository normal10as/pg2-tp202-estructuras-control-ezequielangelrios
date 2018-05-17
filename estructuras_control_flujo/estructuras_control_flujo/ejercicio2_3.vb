Module ejercicio2_3
    Sub Main()
        Dim a, b, c, d, e As Int16
        Dim mayor As Int16
        Console.WriteLine("Ingrese cinco numeros: ")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        e = Console.ReadLine()
        If (a > b And a > c And a > d And a > e) Then
            mayor = a
            Console.WriteLine("El mayor es el primer numero:{0} ", mayor)
        End If
        If (b > a And b > c And b > d And b > e) Then
            mayor = b
            Console.WriteLine("El mayor es el segundo numero:{0} ", mayor)
        End If
        If (c > a And c > b And c > d And a > e) Then
            mayor = c
            Console.WriteLine("El mayor es el tercer numero:{0} ", mayor)
        End If
        If (d > a And d > b And d > c And d > e) Then
            mayor = d
            Console.WriteLine("El mayor es el cuarto numero:{0} ", mayor)
        End If
        If (e > a And e > b And e > c And e > d) Then
            mayor = e
            Console.WriteLine("El mayor es el quinto numero:{0} ", mayor)
        End If
        Console.ReadLine()
    End Sub
End Module
