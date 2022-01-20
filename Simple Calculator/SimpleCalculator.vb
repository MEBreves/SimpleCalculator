'Miranda Breves
'RCET0265
'Spring 2022
'Simple Calculator
'https://github.com/MEBreves/SimpleCalculator

Option Explicit On
Option Strict On

Module SimpleCalculator

    Sub Main()

        'Declaring Variables
        Dim firstInt As Integer
        Dim secondInt As Integer
        Dim calculatorOption As String
        Dim writtenCalculation As String = ""
        Dim calculation As Integer

        'Getting the first integer from the user
        Console.WriteLine("Please enter a number. ")
        firstInt = CInt(Console.ReadLine())
        Console.WriteLine("The number you entered was " & CStr(firstInt) & ".")

        'Getting the second integer from the user
        Console.WriteLine()
        Console.WriteLine("Please enter another number. ")
        secondInt = CInt(Console.ReadLine())
        Console.WriteLine("The number you entered was " & CStr(secondInt) & ".")

        'Having the user select the calculation option
        Console.WriteLine()
        Console.WriteLine("What would you like to calculate? ")
        Console.WriteLine("S: Sum")
        Console.WriteLine("P: Product")
        calculatorOption = Console.ReadLine()
        Console.WriteLine("The option you entered was " & calculatorOption & ".")
        Console.WriteLine()

        'Calculating the product or the sum, depending on the user's response
        If (calculatorOption = "p" Or calculatorOption = "P") Then

            calculation = firstInt * secondInt
            writtenCalculation = (CStr(firstInt) & " * " & CStr(secondInt) & " = " &
                                  CStr(calculation))

        ElseIf (calculatorOption = "s" Or calculatorOption = "S") Then

            calculation = firstInt + secondInt
            writtenCalculation = (CStr(firstInt) & " + " & CStr(secondInt) & " = " &
                                  CStr(calculation))

        Else

            Console.WriteLine("That wasn't even an option, dude.")
            Console.WriteLine()

        End If

        'Displaying calculations, if done, to user
        Console.WriteLine(writtenCalculation)
        Console.WriteLine()
        Console.WriteLine("Please press any key to finish the program.")
        Console.Read()

    End Sub

End Module