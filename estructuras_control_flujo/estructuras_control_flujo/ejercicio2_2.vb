Module ejercicio2_2
    Sub Main()
        Dim num1, num2, num3 As Int16
        Console.WriteLine("ingrese el primer valor: ")
        num1 = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor: ")
        num2 = Console.ReadLine()
        Console.WriteLine("ingrese el tercer valor: ")
        num3 = Console.ReadLine()
        If (num1 < num2 And num1 < num3) Then
            Console.WriteLine("el primer numero {0} es el menor", num1)
        Else
            If (num2 < num1 And num2 < num3) Then
                Console.WriteLine("el segundo numero {0} es el menor", num2)
            Else
                Console.WriteLine("el tercer numero {0} es el menor", num3)
            End If
        End If
        Console.ReadLine()
    End Sub

End Module
