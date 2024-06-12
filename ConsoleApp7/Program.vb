Module Module1
    Sub Main()
        
        Console.WriteLine("Zadejte poèet èísel, které chcete zadat:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        
        Dim cisla(pocetCisel - 1) As Integer
        ' 
        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine("Zadejte èíslo " & (i + 1) & ":")
            cisla(i) = Convert.ToInt32(Console.ReadLine())
        Next
        
        Console.WriteLine("Zadali jste následující èísla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        
        Console.WriteLine("Stisknìte libovolnou klávesu pro ukonèení programu.")
        Console.ReadKey()
    End Sub
End Module
