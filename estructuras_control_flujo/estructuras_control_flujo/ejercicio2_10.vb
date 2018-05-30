Module ejercicio2_10
    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim contador As Integer


        Console.WriteLine("Ingrese el primer valor (menor): ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor(mayor):")
        num2 = Console.ReadLine()
        'Do While num1 < num2
        '    If num1 Mod 5 = 0 Then
        '        contador = contador + 1
        '    End If
        '    num1 = num1 + 1
        'Loop
        'Console.WriteLine("numeros multiplos de 5:" & contador)

        'Do Until (num1 > num2)
        '    If num1 Mod 5 = 0 Then
        '        contador = contador + 1

        '    End If
        '    num1 = num1 + 1
        'Loop
        'Console.WriteLine("numeros multiplos de 5:" & contador)

        'Do
        '    If num1 Mod 5 = 0 Then
        '        contador = contador + 1
        '    End If
        '    num1 = num1 + 1
        'Loop Until num1 > num2
        'Console.WriteLine("numeros multiplos de 5:" & contador)

        'Do
        '    If num1 Mod 5 = 0 Then
        '        contador = contador + 1

        '    End If
        '    num1 = num1 + 1
        'Loop While num1 < num2
        'Console.WriteLine("numeros multiplos de 5:" & contador)

        For x = num1 To num2
            If x Mod 5 = 0 Then
                contador = contador + 1
            End If
        Next
        Console.WriteLine("numeros multiplos de 5:" & contador)
        Console.ReadLine()
    End Sub

End Module
