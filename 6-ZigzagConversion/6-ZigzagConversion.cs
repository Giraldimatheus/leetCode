public class Solution {
    public string Convert(string s, int numRows)
{
    // Se houver uma linha ou a string estiver vazia, retorne a string original
    if (numRows == 1 || numRows >= s.Length)
    {
        return s;
    }

    // Usar um array de StringBuilder para armazenar cada linha
    var rows = new System.Text.StringBuilder[numRows];
    for (int i = 0; i < numRows; i++)
    {
        rows[i] = new System.Text.StringBuilder();
    }

    int currentRow = 0;      // Come�a na linha 0
    bool goingDown = false;  // Dire��o de movimento: para baixo ou para cima

    // Iterar por cada caractere na string
    foreach (char c in s)
    {
        // Adiciona o caractere � linha atual
        rows[currentRow].Append(c);

        // Se estiver na primeira linha ou na �ltima, muda a dire��o
        if (currentRow == 0 || currentRow == numRows - 1)
        {
            goingDown = !goingDown; // Inverte a dire��o
        }

        // Ajusta a linha atual com base na dire��o
        currentRow += goingDown ? 1 : -1;
    }

    // Combina todas as linhas em uma �nica string
    var result = new System.Text.StringBuilder();
    foreach (var row in rows)
    {
        result.Append(row);
    }

    return result.ToString();
}
}