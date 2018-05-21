Module ejercicio2_6
    Sub Main()
        Dim cantidad As Integer
        Dim descuento As Decimal
        Dim precio As Decimal
        Dim preciofinal, preciototal As Decimal

        Console.WriteLine("Ingrese la cantidad de productos: ")
        cantidad = Console.ReadLine()

        Console.WriteLine("Ingrese el precio unitario: ")
        precio = Console.ReadLine()

        If (cantidad < 10) Then
            Console.WriteLine("Usted no tiene descuento")
        End If

        Select Case cantidad
            Case 10 To 50
                descuento = precio * 5 / 100
                Console.WriteLine("El precio unitario es de ${0}, el descuento es de 5%", precio)

            Case 51 To 250
                descuento = precio * 10 / 100
                Console.WriteLine("El precio unitario es de ${0}, el descuento es de 10%", precio)
            Case > 251
                descuento = precio * 20 / 100
                Console.WriteLine("El precio unitario es de ${0}, el descuento es de 20% ", precio)

        End Select
        preciofinal = precio - descuento
        preciototal = cantidad * preciofinal
        Console.WriteLine("Su descuento:$ " & descuento)
        Console.WriteLine("Precio final por producto:$ " & preciofinal)
        Console.WriteLine("Total:$ " & preciototal)
        Console.ReadLine()
    End Sub

End Module
