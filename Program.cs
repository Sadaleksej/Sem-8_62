// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();
int[,] arrr = new int[4, 4];
FilArray(arrr);
PrintArray(arrr);
WriteLine();

void FilArray(int[,] ar)
{
    int i1 = 0;
    int i2 = 0;
    int j1 = 0;
    int j2 = 0;

    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= 4 * 4)

    {
        ar[i, j] = k;
        if (i == i1 && j < 3 - j2)
            j++;
        else if (j == 3 - j2 && i < 3 - i2)
            i++;
        else if (i == 3 - i2 && j > j1)
            j--;
        else
            i--;

        if ((i == i1 + 1) && (j == j1) && (j1 != 3 - j2))
        {
            i1++;
            i2++;
            j1++;
            j2++;

        }
        k++;
    }

}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i, j] + "  ");
        WriteLine();
    }
    WriteLine();
}
