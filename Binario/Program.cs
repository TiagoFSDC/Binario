int valor,resto, quociente, cont = 7;
int[] vetor = new int[8];   

Console.WriteLine("Digite o valor a ser convertido: ");
valor = int.Parse(Console.ReadLine());
conversor(valor);

int[] conversor(int valor)
{
    resto = valor % 2;
    quociente = valor / 2;
    valor = quociente;
    vetor[cont] = resto;
    cont--;
    if(cont >= 0)
    {
        return conversor(valor);
    }
    return vetor;
}


for (int i = 0; i < 8; i++)
{
    Console.Write(vetor[i] + " ");
}