using System;

class Program
{
    static void Main()
    {
        const int velikost = 5;
        int[,] tabulka = new int[velikost, velikost];

        // Načtení čísel od uživatele
        Console.WriteLine("Zadejte čísla pro tabulku 5x5:");

        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                Console.Write($"Zadejte číslo pro pozici [{i + 1},{j + 1}]: ");
                tabulka[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Vytiskne tabulku
        Console.WriteLine("\nTabulka:");

        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                Console.Write(tabulka[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Vypočítá a vytiskne součty řádků
        Console.WriteLine("\nSoučty řádků:");

        for (int i = 0; i < velikost; i++)
        {
            int soucetRadek = 0;
            for (int j = 0; j < velikost; j++)
            {
                soucetRadek += tabulka[i, j];
            }
            Console.WriteLine($"Součet řádku {i + 1}: {soucetRadek}");
        }

        // Vypočítá a vytiskne součty sloupců
        Console.WriteLine("\nSoučty sloupců:");

        for (int j = 0; j < velikost; j++)
        {
            int soucetSloupec = 0;
            for (int i = 0; i < velikost; i++)
            {
                soucetSloupec += tabulka[i, j];
            }
            Console.WriteLine($"Součet sloupce {j + 1}: {soucetSloupec}");
        }

        // Vypočítá a vytiskne součet hlavní diagonály
        int soucetHlavniDiagonala = 0;
        for (int i = 0; i < velikost; i++)
        {
            soucetHlavniDiagonala += tabulka[i, i];
        }
        Console.WriteLine($"\nSoučet hlavní diagonály: {soucetHlavniDiagonala}");

        // Vypočítá a vytiskne součet vedlejší diagonály
        int soucetVedlejsiDiagonala = 0;
        for (int i = 0; i < velikost; i++)
        {
            soucetVedlejsiDiagonala += tabulka[i, velikost - 1 - i];
        }
        Console.WriteLine($"Součet vedlejší diagonály: {soucetVedlejsiDiagonala}");
    }
}





