Module Module1
    Sub Main()
        ' Zjist�me, kolik ��sel chce u�ivatel zadat
        Console.WriteLine("Zadejte po�et ��sel, kter� chcete zadat:")
        Dim pocetCisel As Integer = Convert.ToInt32(Console.ReadLine())
        ' Pole pro ulo�en� ��sel
        Dim cisla(pocetCisel - 1) As Integer
        ' Cyklick� zad�v�n� ��sel
        For i As Integer = 0 To pocetCisel - 1
            Console.WriteLine("Zadejte ��slo " & (i + 1) & ":")
            cisla(i) = Convert.ToInt32(Console.ReadLine())
        Next
        ' Vyhodnocen� v�sledk�
        Console.WriteLine("Zadali jste n�sleduj�c� ��sla:")
        For Each cislo As Integer In cisla
            Console.WriteLine(cislo)
        Next
        ' Ukon�en� programu
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en� programu.")
        Console.ReadKey()
    End Sub
End Module