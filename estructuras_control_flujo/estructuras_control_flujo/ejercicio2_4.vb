Module ejercicio2_4
    Sub Main()
        Dim cantidad As Integer
        Dim precio As Decimal
        Dim descuento As Decimal
        Dim preciofinal As Decimal
        Console.WriteLine("Ingrese la cantidad de productos: ")
        cantidad = Console.ReadLine()
        Console.WriteLine("Ingrese el precio unitario: ")
        precio = Console.ReadLine()
        If (cantidad < 10) Then
            Console.WriteLine("Usted no tiene descuento :(")
        End If
        If (cantidad >= 10 And cantidad <= 50) Then
            descuento = precio * 5 / 100
            preciofinal = precio - descuento
            Console.WriteLine("El subtotal es {0}, su porcentaje de descuento 5%, el monto descontado ${1}, y el total ${2}", precio, descuento, preciofinal)
        End If
        If (cantidad >= 51 And cantidad <= 250) Then
            descuento = precio * 10 / 100
            preciofinal = precio - descuento
            Console.WriteLine("El subtotal es {0}, su porcentaje de descuento 10%, el monto descontado ${1}, y el total ${2}", precio, descuento, preciofinal)

        End If
        If (cantidad >= 251) Then
            descuento = precio * 20 / 100
            preciofinal = precio - descuento
            Console.WriteLine("El subtotal es {0}, su porcentaje de descuento 20%, el monto descontado ${1}, y el total ${2}", precio, descuento, preciofinal)
        End If
        Console.ReadLine()
    End Sub

End Module
