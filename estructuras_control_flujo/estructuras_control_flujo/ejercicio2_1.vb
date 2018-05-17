Module ejercicio2_1

    Sub Main()
        Dim num1 As Int16
        Dim num2 As Int16
        Console.WriteLine("ingrese el primer numero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese el segundo numero: ")
        num2 = Console.ReadLine()
        If (num1 < num2) Then
            Console.WriteLine("el primer numero {0} es menor que el segundo {1}", num1, num2)
        End If
        If (num1 > num2) Then
            Console.WriteLine("el primer numero {0} es mayor que el segundo {1}", num1, num2)
        End If
        If (num1 = num2) Then
            Console.WriteLine("el primer numero {0} es igual al segundo numero {1}", num1, num2)
        End If
        Console.ReadLine()
    End Sub

End Module
