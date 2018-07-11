Module Module1
    'Skapad av Markus Nordin
    'Skapa ett program som räknar vokalerna i en sträng
    'Generera statistik för varje vokal
    Sub Main()
        Dim testString As String = "Skapa ett program som räknar vokalerna i en sträng"
        Dim bokstav As Char = ""
        Dim iRäknare(9) As Integer

        For Each bokstav In testString
            Select Case bokstav
                Case "a"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(1) = iRäknare(1) + 1
                Case "e"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(2) = iRäknare(2) + 1
                Case "i"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(3) = iRäknare(3) + 1
                Case "o"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(4) = iRäknare(4) + 1
                Case "u"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(5) = iRäknare(5) + 1
                Case "y"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(6) = iRäknare(6) + 1
                Case "å"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(7) = iRäknare(7) + 1
                Case "ä"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(8) = iRäknare(8) + 1
                Case "ö"
                    iRäknare(0) = iRäknare(0) + 1
                    iRäknare(9) = iRäknare(9) + 1

            End Select
        Next
        Console.WriteLine("Strängen som skall kollas: " & testString)
        Console.WriteLine("Antalet totala vokaler är " & iRäknare(0).ToString)
        Console.WriteLine("a = " & iRäknare(1).ToString)
        Console.WriteLine("e = " & iRäknare(2).ToString)
        Console.WriteLine("i = " & iRäknare(3).ToString)
        Console.WriteLine("o = " & iRäknare(4).ToString)
        Console.WriteLine("u = " & iRäknare(5).ToString)
        Console.WriteLine("y = " & iRäknare(6).ToString)
        Console.WriteLine("å = " & iRäknare(7).ToString)
        Console.WriteLine("ä = " & iRäknare(8).ToString)
        Console.WriteLine("ö = " & iRäknare(9).ToString)
        Console.WriteLine("Tryck på en knapp för att avsluta")
        Console.ReadKey()

    End Sub

End Module
